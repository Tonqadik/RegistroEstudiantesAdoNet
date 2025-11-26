using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LocalReport = Microsoft.Reporting.WinForms.LocalReport;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;
using ReportParameterCollection = Microsoft.Reporting.WinForms.ReportParameterCollection;
using Warning = Microsoft.Reporting.WinForms.Warning;

namespace RegistrosAlumnos
{
    public enum TipoLog
    {
        DEBUG,
        INFO,
        WARN,
        ERROR
    }
    public partial class Form1 : Form
    {
        ConeccionSql conn = new ConeccionSql();
        List<string> cedulas = new List<string>(); // La lista de cedulas es utilizada para buscar un estudiante en especifico si se selecciona una fila
        string codigoProfesor = "admin123";

        public Form1()
        {
            InitializeComponent();
        }

        // Carga inicial del forms
        private void Form1_Load(object sender, EventArgs e)
        {
            Log.IniciarLog();
            crearInputBoxInicio();
            comboBoxCarrera.SelectedIndex = 0;
            this.KeyPreview = true; // Permite que los eventos primeros pasen por el forms

            // Conexión al servidor SQl
            conn.conectarBaseDeDatos();
            BoxID.Text = (conn.obtenerAlumnos().Count + 1).ToString();
            inicializarTabla();
        }

        //**************************  MENSAJES DEL SISTEMA *************************
        public void crearInputBoxInicio()
        {
            string inputUsuario = Microsoft.VisualBasic.Interaction.InputBox("Código de inicio de sesión", "Inicio de sesión");

            if (inputUsuario.Equals(codigoProfesor))
            {
                Log.AddLinea("Se inicia la sesión en el sistema");
                MessageBox.Show("Código correcto.\nIniciando sesión...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Log.AddLinea("El código de profesor es incorrecto, se cerrara la aplicación", TipoLog.WARN);
                MessageBox.Show("Código incorrecto.\nCerrando aplicación...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        // El método se encarga de validar si todos los campos están o no vacíos, en caso de estar uno, entonces retorna false, en caso contraio true,
        public bool crearInputBoxValidar() 
        {
            Log.AddLinea("Iniciando comprobaciones de los campos");
            bool validado = (
                !string.IsNullOrEmpty(BoxContrasena.Text)
                && !string.IsNullOrEmpty(BoxNombre.Text)
                && !string.IsNullOrEmpty(BoxCedula.Text)
                && (radMatutino.Checked || radVesperina.Checked)
                && (radISemestre.Checked || radIISemestre.Checked || radVerano.Checked)
                && !string.IsNullOrEmpty(comboBoxCarrera.Text)
                && checkTerminos.Checked
                );

            if (validado)
            {
                Log.AddLinea("Estudiante guardado");
            }
            else
            {
                Log.AddLinea("Error al guardar estudiante, hay campos vacíos", TipoLog.WARN);
                MessageBox.Show("Hay campos vacíos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validado;
        }


        //********************** EVENTOS DE LOS BOTONES DEL FORMS ******************
        private void limpiarForm()
        {
            Log.AddLinea("Forms limpiado");
            BoxID.Clear();
            BoxUsuario.Clear();
            BoxContrasena.Clear();
            BoxNombre.Clear();
            BoxCedula.Clear();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            editarAlumno();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardarAlumno();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
        }

        // Toolbar para salir de la app
        private void salirMenuToolbarItem_Click(object sender, EventArgs e)
        {
            conn.cerrarBaseDeDatos();
            Log.AddLinea("Cerrando aplicación");
            Application.Exit();
        }

        // Toolbar para guardar alumno
        private void guardarMenuToolbarItem_Click(object sender, EventArgs e)
        {
            guardarAlumno();
        }

        // Toolbar para eliminar alumno
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarAlumno();

        }

        // Toolbar para editar alumno
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editarAlumno();
        }

        // Toolbar para hacer un nuevo alumno
        private void nuevoMenuToolbarItem_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        // Método que lee la base de datos, y añade la lista de alumnos como el DataSource de la tabla (Este solo se llama al principio)
        private void inicializarTabla()
        {
            cedulas.Clear();
            Log.AddLinea("Tabla grid de estudiantes inicializada");

            TableGridAlumnos.DataSource = conn.obtenerAlumnos();
        }

        // Método para guardar que guarda toda la información del alumno para enviarla al ADO.Net
        private void guardarAlumno()
        {
            try {
                // Válida que no haya campos vacíos
                if (!crearInputBoxValidar()) { return; } 
                var id = conn.obtenerAlumnos().Count; 
                string jornada = radMatutino.Checked ? "Matutino" : "Vesperino"; // Obtiene la jornada seleccionada
                string semestre = "";
                if (radISemestre.Checked) { semestre = "I"; } else { if (radIISemestre.Checked) { semestre = "II"; } else { semestre = "Verano"; } } // Obtiene el semestre seleccionado
                BoxID.Text = (id + 1).ToString(); // Cambia el id al siguiente

                // Se crea un objeto de alumno el cuál se envia al Ado.Net
                Alumno al = new(id.ToString(), BoxNombre.Text, BoxCedula.Text, comboBoxCarrera.Text, semestre, jornada, BoxUsuario.Text, BoxContrasena.Text, checkNotificaciones.Checked);
                conn.anadirAlumno(al); 
                cedulas.Add(al.Cedula);
                MessageBox.Show("Estudiante guardado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ep)
            {
                MessageBox.Show("Ha ocurrido una operación inválida.\nNo se pudo eliminar al estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para eliminar el alumno 
        private void eliminarAlumno()
        {
            try
            {
                // En caso de que el estudiante no exista, entonces da un mensaje de error
                if (!conn.existeEstudiante(BoxCedula.Text)) { MessageBox.Show("El estudiante no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                // Se muestra un mensaje de confirmación para eliminar el estudiante
                if (MessageBox.Show($"Estás seguro que deseas eliminar el estudiante con cédula {BoxCedula.Text}?.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) { return; }
                // Se envía la cédula del estudiante a eliminar
                conn.eliminarAlumno(BoxCedula.Text);
                MessageBox.Show("Se elimino el estudiante.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarTabla(); // Se recarfa la tabla
                limpiarForm();
            }
            catch (InvalidOperationException ep)
            {
                MessageBox.Show("Ha ocurrido una operación inválida.\nNo se pudo eliminar al estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void editarAlumno()
        {
            try
            {
                // Válida que no haya campos vacíos
                if (!crearInputBoxValidar()) { return; } 
                // En caso de que el estudiante no exista, entonces da un mensaje de error
                if (!conn.existeEstudiante(BoxCedula.Text)) { MessageBox.Show("El estudiante no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                string jornada = radMatutino.Checked ? "Matutino" : "Vesperino";
                string semestre = "";
                if (radISemestre.Checked) { semestre = "I"; } else { if (radIISemestre.Checked) { semestre = "II"; } else { semestre = "Verano"; } }
                
                // Se crea un objeto de alumno el cuál se envia al Ado.Net
                Alumno al = new("", BoxNombre.Text, BoxCedula.Text, comboBoxCarrera.Text, semestre, jornada, BoxUsuario.Text, BoxContrasena.Text, checkNotificaciones.Checked);
                // Se envía el objeto al Ado.Net
                conn.modificarAlumno(al);
                MessageBox.Show("Se modifico el estudiante.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarTabla();
            }
            catch (InvalidOperationException ep)
            {
                MessageBox.Show("Ha ocurrido una operación inválida.\nNo se pudo editar al estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /********************************* MÉTDODOS DE LOS REPORTES ****************************************/

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteGeneral(null);
        }
        private void matutinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteJornada(null, "Matutino");
        }

        private void vesperinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteJornada(null, "Vesperino");
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!crearInputBoxValidar()) { return; }
            if (!conn.existeEstudiante(BoxCedula.Text)) { MessageBox.Show("El estudiante no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            conn.obtenerReporteAlumno(null, BoxCedula.Text);
        }



        private void rangoFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se crea un calendarDialog personalizado
            MonthCalendar calendar = new MonthCalendar();
            Button okButton = new Button();
            Button cancelButton = new Button();
            Label label = new Label();
            Form f = new Form();
            f.Size = new Size(350, 350);
            f.Controls.Add(calendar);
            f.Controls.Add(okButton);
            f.Controls.Add(cancelButton);
            f.Controls.Add(label);
            f.AcceptButton = okButton;
            f.CancelButton = cancelButton;
            f.BackColor = Color.White;

            label.Text = "Elija el rango de fechas";
            label.AutoSize = true;
            label.Location = new Point(40, 0);

            calendar.Location = new Point(40, 20);
            calendar.MaxDate = DateTime.Now;
            calendar.MinDate = new DateTime(1990, 1, 1);
            calendar.ShowToday = false;
            calendar.MaxSelectionCount = 30;

            okButton.Location = new Point(40, 240);
            okButton.Text = "Ok";
            okButton.AutoSize = true;
            okButton.BackColor = Color.LightBlue;
            okButton.Padding = new Padding(6);
            okButton.DialogResult = DialogResult.OK;

            cancelButton.Location = new Point(215, 240);
            cancelButton.Text = "Cancelar";
            cancelButton.AutoSize = true;
            cancelButton.BackColor = Color.LightSalmon;
            cancelButton.Padding = new Padding(6);
            cancelButton.DialogResult = DialogResult.Cancel;

            var result = f.ShowDialog();


            if (result == DialogResult.OK)
            {
                conn.obtenerReporteFecha(null, calendar.SelectionRange.Start.ToShortDateString(), calendar.SelectionRange.End.ToShortDateString());
            }

        }

        private void cienciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteCarrera(null, "Ciencias de la Computación");
        }

        private void ciberseguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteCarrera(null, "Ciberseguridad");
        }

        private void desarrolloYGestiónDeSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteCarrera(null, "Desarrollo y Gestión de Software");
        }

        private void redesInformáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.obtenerReporteCarrera(null, "Redes Informáticas");
        }

        /************************************ MÉTODOS DE KEY PRESS  ***************************************/
        bool CedulaValida = true;        
        private void BoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CedulaValida) e.Handled = true;


        }

        // El método valida si la tecla presionada es válida
        private void BoxCedula_KeyDown(object sender, KeyEventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            string keyChar = kc.ConvertToString(e.KeyData);
            Regex regex = new Regex("[^0-9-]+");
            CedulaValida = regex.IsMatch(keyChar);
            if (e.KeyCode == Keys.OemMinus) CedulaValida = false;
            if (e.KeyCode == Keys.OemMinus && BoxCedula.Text.Length == 0) CedulaValida = true;
        }



        private void BoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // No permite números en los nombres
            {
                e.Handled = true;
            }
        }

        private void BoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (BoxCedula.Text.Length > 0 && BoxNombre.Text.Length > 0)
            {
                BoxUsuario.Text = BoxNombre.Text + BoxCedula.Text;
            }
        }

        private void BoxCedula_TextChanged(object sender, EventArgs e)
        {
            if (BoxCedula.Text.Length > 0 && BoxNombre.Text.Length > 0)
            {
                BoxUsuario.Text = BoxNombre.Text + BoxCedula.Text;
            }
        }

        // *********************** EVENTOS VALIDATING *************************
        private void recargarTabla()
        {
            inicializarTabla();
        }
        private void BoxNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(BoxNombre.Text))
            {
                errorProvider1.SetError(BoxNombre, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void BoxCedula_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(BoxCedula.Text))
            {
                errorProvider2.SetError(BoxCedula, "El campo no puede estar vacío");
            }
            else
            {
                errorProvider2.Clear();
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Log.AddLinea("Cerrando aplicación");
                e.SuppressKeyPress = true;
                conn.cerrarConexionBaseDatos();
                this.Close();
                Application.Exit();
            }
        }



        private void TableGridAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            Alumno alumno = conn.obtenerAlumno(TableGridAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString());
            BoxUsuario.Text = alumno.Usuario;
            BoxContrasena.Text = alumno.Contrasena;
            BoxNombre.Text = alumno.Nombre;
            BoxCedula.Text = alumno.Cedula;
            if (alumno.Jornada == "Matutino") { radMatutino.Checked = true; } else { radVesperina.Checked = true; }
            if (alumno.Semestre == "I") { radISemestre.Checked = true; } else { if (alumno.Semestre == "II") { radIISemestre.Checked = true; } else { radVerano.Checked = true; } }
            checkNotificaciones.Checked = alumno.RecibirNot;
            comboBoxCarrera.SelectedItem = alumno.Carrera;

        }

    }

    /**************************************************************
     ***************                       ************************
     ***************        CLASE LOG      ************************
     ***************                       ************************
     **************************************************************/
    public class Log
    {

        // Añade una línea al log, junto con el tipo
        public static void AddLinea(string linea, TipoLog tipo)
        {
            System.IO.File.AppendAllText("Log.txt", $"{DateTime.Now.ToString()}" + $" -{tipo}-".PadRight(8) + $" {linea}\n");
        }

        // Añade una línea al log
        public static void AddLinea(string linea)
        {

            System.IO.File.AppendAllText("Log.txt", $"{DateTime.Now.ToString()} -INFO-  {linea}\n");
        }

        // Se crea el archivo log
        public static void IniciarLog()
        {
            System.IO.File.WriteAllText("Log.txt", ""); // Crea el archivo log, en caso de existir, entonces borra su contenido
            Log.AddLinea("Programa iniciado");
        }

    }

    /**************************************************************
     ***************                       ************************
     *************** CLASE CONEXIÓN SQL    ************************
     ***************                       ************************
     **************************************************************/
    public class ConeccionSql
    {
        public string sqlConexion = @"Data Source = localhost;" +
            "Initial Catalog=DBAlumnos;" +
            "TrustServerCertificate=true;Integrated Security=True; user=";
        SqlConnection conn;


        public void conectarBaseDeDatos()
        {
            conn = new SqlConnection(sqlConexion);
            conn.Open();
        }

        public void cerrarBaseDeDatos()
        {
            conn.Close();
        }

        //***************** MÉTODOS CRUD ********************
        public bool anadirAlumno(Alumno almn)
        {
            try {             
                if (!comprobarConexion()) return false; // En caso de que la conexión no este abierta entonces regresa
                SqlCommand comando = crearComando("INSERT INTO Alumnos( Nombre, Cedula, Carrera, Semestre, Jornada, Usuario, Contrasena, RecibirNotificaciones) VALUES ( @N, @C1,  @C2, @S, @T, @user, @contra, @not)");
                comando.Parameters.Add("@N", SqlDbType.NVarChar, 100).Value = almn.Nombre;
                comando.Parameters.Add("@C1", SqlDbType.NVarChar, 20).Value = almn.Cedula;
                comando.Parameters.Add("@C2", SqlDbType.NVarChar, 50).Value = almn.Carrera;
                comando.Parameters.Add("@S", SqlDbType.NVarChar, 20).Value = almn.Semestre;
                comando.Parameters.Add("@T", SqlDbType.NVarChar, 20).Value = almn.Jornada;
                comando.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = almn.Usuario;
                comando.Parameters.Add("@contra", SqlDbType.NVarChar, 100).Value = almn.Contrasena;
                comando.Parameters.Add("@not", SqlDbType.Bit).Value = almn.RecibirNot;
                comando.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                throw;
            }

        }
        public bool eliminarAlumno(String ced)
        {
            try
            {
                if (!comprobarConexion()) return false; // En caso de que la conexión no este abierta entonces regresa
                SqlCommand comando = crearComando("Delete from Alumnos where Cedula = @ced;");
                comando.Parameters.Add("@ced",SqlDbType.NVarChar, 255).Value = ced;
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                throw;
            }

        }

        public bool modificarAlumno(Alumno almn)
        {
            try
            {
                if (!comprobarConexion()) return false; // En caso de que la conexión no este abierta entonces regresa
                SqlCommand comando = crearComando(" UPDATE Alumnos " +
                    "SET  Nombre = @N, Carrera = @C, Semestre = @S, Jornada = @T, Usuario = @user, Contrasena = @contra, RecibirNotificaciones = @not " +
                    "where cedula = @ced;");
                comando.Parameters.Add("@N", SqlDbType.NVarChar, 100).Value = almn.Nombre;
                comando.Parameters.Add("@ced", SqlDbType.NVarChar, 20).Value = almn.Cedula;
                comando.Parameters.Add("@C", SqlDbType.NVarChar, 50).Value = almn.Carrera;
                comando.Parameters.Add("@S", SqlDbType.NVarChar, 20).Value = almn.Semestre;
                comando.Parameters.Add("@T", SqlDbType.NVarChar, 20).Value = almn.Jornada;
                comando.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = almn.Usuario;
                comando.Parameters.Add("@contra", SqlDbType.NVarChar, 100).Value = almn.Contrasena;
                comando.Parameters.Add("@not", SqlDbType.Bit).Value = almn.RecibirNot;
                string query = comando.CommandText;

                foreach (SqlParameter p in comando.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }

                comando.ExecuteNonQuery();
                return true;
            }catch(Exception e)
            {
                throw;
            }
        }

        // Obtiene la lista de todos los alumnos(utiliza una versión con menos datos de los alumnos)
        public List<AlumnoLista> obtenerAlumnos()
        {
            SqlCommand comando = crearComando("select * from Alumnos;");
            using SqlDataReader reader = comando.ExecuteReader();
            List<AlumnoLista> lista = new List<AlumnoLista>();

            while (reader.Read()) {
                lista.Add(new AlumnoLista(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetString(3), reader.GetString(5) ));
            }

            return lista;
        }
        // Obtiene un alumno según su cédula
        public Alumno obtenerAlumno(string cedula)
        {
            SqlCommand comando = crearComando("select * from Alumnos where Cedula = @ced;");
            comando.Parameters.Add("@ced", SqlDbType.NVarChar, 20).Value = cedula;
            using SqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            return new Alumno(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetBoolean(8));
        }

        public bool existeEstudiante(string cedula)
        {
            SqlCommand comando = crearComando("select * from Alumnos where Cedula = @ced;");
            comando.Parameters.Add("@ced", SqlDbType.NVarChar, 20).Value = cedula;
            using SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                return reader.GetInt32(0) >= 1;
            }
            return false;
        }



        //***************** MÉTODOS REPORTES ********************
        public void obtenerReporteGeneral(ReportViewer rv)
        {
            ReporterManager rep = new ReporterManager(rv);
            rep.crearReporteGeneral(crearComando("Select * from Alumnos;"));
        }

        public void obtenerReporteJornada(ReportViewer rv, string jornada)
        {
            ReporterManager rep = new ReporterManager(rv);
            rep.crearReporteJornada(crearComando($"Select * from Alumnos where Jornada = '{jornada}';"), jornada);
        }
        
        public void obtenerReporteAlumno(ReportViewer rv, string cedula)
        {
            ReporterManager rep = new ReporterManager(rv);
            rep.crearReporteAlumno(crearComando($"Select * from Alumnos where Cedula = '{cedula}';"));
        }
        public void obtenerReporteCarrera(ReportViewer rv, string carrera)
        {
            ReporterManager rep = new ReporterManager(rv);
            rep.crearReporteCarrera(crearComando($"Select * from Alumnos where Carrera = '{carrera}';"), carrera);
        }
        

        public void obtenerReporteFecha(ReportViewer rv, string fechaInicio, string fechaFinal)
        {
            ReporterManager rep = new ReporterManager(rv); 
            rep.crearReporteFecha(crearComando($"Select * from Alumnos where FechaRegistro between '{fechaInicio}' and '{fechaFinal}';"), $"{fechaInicio} hasta {fechaFinal}");

        }

        public bool comprobarConexion()
        {
            if (conn.State == ConnectionState.Open) {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public SqlCommand crearComando(String comando) { return new SqlCommand(comando, conn); }

        internal void cerrarConexionBaseDatos()
        {
            throw new NotImplementedException();
        }
    }

    /**************************************************************
     ***************                       ************************
     *************** CLASE REPORT MANAGER  ************************
     ***************                       ************************
     **************************************************************/

    public class ReporterManager
    {
        private ReportViewer rv;
        public ReporterManager(ReportViewer reportV)
        {
            rv = reportV;
        }

        /********************* REPORTES DEL FORMS **************************/
        public void crearReporteGeneral(SqlCommand SqlConn)
        {
            SqlDataAdapter data = new SqlDataAdapter(SqlConn);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SQLToPdf("Reporte general de estudiantes", "ReporteGeneral", tabla);
        }
        public void crearReporteAlumno(SqlCommand SqlConn)
        {
            SqlDataAdapter data = new SqlDataAdapter(SqlConn);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SQLToPdf("Reporte del alumno", "ReporteAlumno", tabla);
        }        

        public void crearReporteJornada(SqlCommand SqlConn, string jornada)
        {
            SqlDataAdapter data = new SqlDataAdapter(SqlConn);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SQLToPdf($"Reporte de jornada {jornada}", "ReporteJornada", tabla, jornada);
        }

        public void crearReporteCarrera(SqlCommand SqlConn, string carrera)
        {
            SqlDataAdapter data = new SqlDataAdapter(SqlConn);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SQLToPdf($"Reporte de carrera {carrera}", $"ReporteCarrera", tabla, carrera);
        }

        public void crearReporteFecha(SqlCommand SqlConn, string fechas)
        {
            SqlDataAdapter data = new SqlDataAdapter(SqlConn);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SQLToPdf($"Reporte de jornada {fechas.Replace("/","-")}", $"ReporteFechas", tabla, fechas);
        }

        /************ MÉTODOS PARA GUARDAR EN UN ARCHIVO ***************/
        private void SQLToPdf(string Filename, string tipoReporte,DataTable tabla, string parametro = "")
        {

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            LocalReport report = new LocalReport();
            report.ReportPath = "../../../" +tipoReporte+ ".rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", tabla);
            report.DataSources.Add(rds);

            if (report.GetParameters().Count > 0)
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("ReportParameter1", parametro.ToLower()));
                report.SetParameters(reportParameters);
            }

            byte[] bytes = report.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            abrirDialog(bytes, Filename.ToLower());
        }

        /*************** MÉTODOS PARA PODER GUARDAR SAVEDIALOG *************/
        private void abrirDialog(byte[] info, string fileName)
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.Title = "Guarda el reporte";
            svg.FileName = $"{fileName}.pdf";
            svg.Filter = "Pdf Files|*.pdf";

            if (svg.ShowDialog() == DialogResult.OK)
            {
                using (FileStream sw = new FileStream(svg.FileName, FileMode.Create))
                    sw.Write(info, 0, info.Length);
            }
        }
    }

    public class AlumnoLista(int Id,string ced, string N, string C, string T)
        {
        public int id { get; init; } = Id;
        public string Cedula { get; init; } = ced;
        public string Nombre { get; init; } = N;
        public string Carrera { get; init; } = C;
        public string Jornada { get; init; } = T;

    };

    public class Alumno(string Id, string N, string C1, string C2, string S, string T, string user, string contra, bool recibirNot)
        {
            public string Id { get; init; } = Id;
            public string Nombre { get; init; } = N;
            public string Cedula { get; init; } = C1;
            public string Carrera { get; init; } = C2;
            public string Usuario { get; init; } = user;
            public string Contrasena { get; init; } = contra;
            public string Semestre { get; init; } = S;
            public string Jornada { get; init; } = T;
            public bool RecibirNot { get; init; } = recibirNot;

        };
        


}
