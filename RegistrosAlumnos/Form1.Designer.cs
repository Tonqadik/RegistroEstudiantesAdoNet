namespace RegistrosAlumnos
{

    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            TableGridAlumnos = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            label6 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label13 = new Label();
            label12 = new Label();
            flowLayoutPanel10 = new FlowLayoutPanel();
            BoxUsuario = new TextBox();
            BoxContrasena = new TextBox();
            flowLayoutPanel12 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            BoxNombre = new TextBox();
            BoxCedula = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label4 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            radMatutino = new RadioButton();
            radVesperina = new RadioButton();
            label8 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            radISemestre = new RadioButton();
            radIISemestre = new RadioButton();
            radVerano = new RadioButton();
            label5 = new Label();
            comboBoxCarrera = new ComboBox();
            label7 = new Label();
            flowLayoutPanel13 = new FlowLayoutPanel();
            checkTerminos = new CheckBox();
            checkNotificaciones = new CheckBox();
            flowLayoutPanel14 = new FlowLayoutPanel();
            BtnNuevo = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnEliminar = new Button();
            groupBox2 = new GroupBox();
            MenuToolbar = new MenuStrip();
            archivoMenuToolbarItem = new ToolStripMenuItem();
            nuevoMenuToolbarItem = new ToolStripMenuItem();
            guardarMenuToolbarItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            generalToolStripMenuItem = new ToolStripMenuItem();
            estudianteToolStripMenuItem = new ToolStripMenuItem();
            carreraToolStripMenuItem = new ToolStripMenuItem();
            ciberseguridadToolStripMenuItem = new ToolStripMenuItem();
            cienciasToolStripMenuItem = new ToolStripMenuItem();
            desarrolloYGestiónDeSoftwareToolStripMenuItem = new ToolStripMenuItem();
            redesInformáticasToolStripMenuItem = new ToolStripMenuItem();
            jornadaToolStripMenuItem = new ToolStripMenuItem();
            matutinoToolStripMenuItem = new ToolStripMenuItem();
            vesperinoToolStripMenuItem = new ToolStripMenuItem();
            rangoFechasToolStripMenuItem = new ToolStripMenuItem();
            salirMenuToolbarItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableGridAlumnos).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel13.SuspendLayout();
            flowLayoutPanel14.SuspendLayout();
            groupBox2.SuspendLayout();
            MenuToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(TableGridAlumnos);
            groupBox1.Location = new Point(385, 35);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 616);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de estudiantes";
            // 
            // TableGridAlumnos
            // 
            TableGridAlumnos.AllowUserToAddRows = false;
            TableGridAlumnos.AllowUserToDeleteRows = false;
            TableGridAlumnos.AllowUserToResizeColumns = false;
            TableGridAlumnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TableGridAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TableGridAlumnos.BackgroundColor = SystemColors.ControlLight;
            TableGridAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableGridAlumnos.Dock = DockStyle.Fill;
            TableGridAlumnos.Location = new Point(3, 21);
            TableGridAlumnos.Name = "TableGridAlumnos";
            TableGridAlumnos.ReadOnly = true;
            TableGridAlumnos.RowHeadersWidth = 51;
            TableGridAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableGridAlumnos.ShowEditingIcon = false;
            TableGridAlumnos.Size = new Size(666, 592);
            TableGridAlumnos.TabIndex = 1;
            TableGridAlumnos.CellClick += TableGridAlumnos_CellClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel12);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(20, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(305, 653);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Controls.Add(label6);
            flowLayoutPanel11.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel11.Location = new Point(3, 3);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(297, 110);
            flowLayoutPanel11.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 0);
            label6.Margin = new Padding(7, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 5;
            label6.Text = "Credenciales";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel7.Controls.Add(flowLayoutPanel10);
            flowLayoutPanel7.Location = new Point(3, 23);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(294, 101);
            flowLayoutPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.Controls.Add(label13);
            flowLayoutPanel9.Controls.Add(label12);
            flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel9.Location = new Point(3, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(94, 64);
            flowLayoutPanel9.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 14, 0, 0);
            label13.Size = new Size(64, 32);
            label13.TabIndex = 5;
            label13.Text = "Usuario";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 32);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 14, 0, 0);
            label12.Size = new Size(88, 32);
            label12.TabIndex = 5;
            label12.Text = "Contraseña";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.Controls.Add(BoxUsuario);
            flowLayoutPanel10.Controls.Add(BoxContrasena);
            flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel10.Location = new Point(103, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(131, 62);
            flowLayoutPanel10.TabIndex = 1;
            // 
            // BoxUsuario
            // 
            BoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            BoxUsuario.Location = new Point(3, 3);
            BoxUsuario.Name = "BoxUsuario";
            BoxUsuario.ReadOnly = true;
            BoxUsuario.Size = new Size(125, 25);
            BoxUsuario.TabIndex = 4;
            // 
            // BoxContrasena
            // 
            BoxContrasena.BorderStyle = BorderStyle.FixedSingle;
            BoxContrasena.Location = new Point(3, 34);
            BoxContrasena.MaxLength = 12;
            BoxContrasena.Name = "BoxContrasena";
            BoxContrasena.PasswordChar = '*';
            BoxContrasena.Size = new Size(125, 25);
            BoxContrasena.TabIndex = 5;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Controls.Add(label1);
            flowLayoutPanel12.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel12.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel12.Location = new Point(3, 119);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(302, 507);
            flowLayoutPanel12.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 0);
            label1.Margin = new Padding(7, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 4;
            label1.Text = "Datos del alumno";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel5.Location = new Point(3, 23);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(299, 86);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(62, 62);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 9, 0, 0);
            label2.Size = new Size(56, 27);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 14, 0, 0);
            label3.Size = new Size(56, 32);
            label3.TabIndex = 5;
            label3.Text = "Cédula";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(BoxNombre);
            flowLayoutPanel3.Controls.Add(BoxCedula);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(103, 3);
            flowLayoutPanel3.Margin = new Padding(35, 3, 3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(191, 62);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // BoxNombre
            // 
            BoxNombre.BorderStyle = BorderStyle.FixedSingle;
            BoxNombre.Location = new Point(3, 3);
            BoxNombre.Name = "BoxNombre";
            BoxNombre.Size = new Size(125, 25);
            BoxNombre.TabIndex = 3;
            BoxNombre.TextChanged += BoxNombre_TextChanged;
            BoxNombre.KeyPress += BoxNombre_KeyPress;
            BoxNombre.Validating += BoxNombre_Validating;
            // 
            // BoxCedula
            // 
            BoxCedula.BorderStyle = BorderStyle.FixedSingle;
            BoxCedula.Location = new Point(3, 34);
            BoxCedula.Name = "BoxCedula";
            BoxCedula.Size = new Size(125, 25);
            BoxCedula.TabIndex = 5;
            BoxCedula.TextChanged += BoxCedula_TextChanged;
            BoxCedula.KeyDown += BoxCedula_KeyDown;
            BoxCedula.KeyPress += BoxCedula_KeyPress;
            BoxCedula.Validating += BoxCedula_Validating;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label4);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel6.Controls.Add(label8);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel6.Controls.Add(label5);
            flowLayoutPanel6.Controls.Add(comboBoxCarrera);
            flowLayoutPanel6.Controls.Add(label7);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel13);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel14);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(3, 115);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(250, 375);
            flowLayoutPanel6.TabIndex = 1;
            flowLayoutPanel6.WrapContents = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 0;
            label4.Text = "Turno";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(radMatutino);
            flowLayoutPanel4.Controls.Add(radVesperina);
            flowLayoutPanel4.Location = new Point(3, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(250, 55);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // radMatutino
            // 
            radMatutino.AutoSize = true;
            radMatutino.Location = new Point(3, 3);
            radMatutino.Name = "radMatutino";
            radMatutino.Size = new Size(93, 22);
            radMatutino.TabIndex = 0;
            radMatutino.TabStop = true;
            radMatutino.Text = "Matutina";
            radMatutino.UseVisualStyleBackColor = true;
            // 
            // radVesperina
            // 
            radVesperina.AutoSize = true;
            radVesperina.Location = new Point(102, 3);
            radVesperina.Name = "radVesperina";
            radVesperina.Size = new Size(109, 22);
            radVesperina.TabIndex = 1;
            radVesperina.TabStop = true;
            radVesperina.Text = "Vespertina";
            radVesperina.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label8.Location = new Point(3, 79);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 3;
            label8.Text = "Semestre";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(radISemestre);
            flowLayoutPanel8.Controls.Add(radIISemestre);
            flowLayoutPanel8.Controls.Add(radVerano);
            flowLayoutPanel8.Location = new Point(3, 100);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(250, 55);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // radISemestre
            // 
            radISemestre.AutoSize = true;
            radISemestre.Location = new Point(3, 3);
            radISemestre.Name = "radISemestre";
            radISemestre.Size = new Size(37, 22);
            radISemestre.TabIndex = 0;
            radISemestre.TabStop = true;
            radISemestre.Text = "I";
            radISemestre.UseVisualStyleBackColor = true;
            // 
            // radIISemestre
            // 
            radIISemestre.AutoSize = true;
            radIISemestre.Location = new Point(46, 3);
            radIISemestre.Name = "radIISemestre";
            radIISemestre.Size = new Size(45, 22);
            radIISemestre.TabIndex = 1;
            radIISemestre.TabStop = true;
            radIISemestre.Text = "II";
            radIISemestre.UseVisualStyleBackColor = true;
            // 
            // radVerano
            // 
            radVerano.AutoSize = true;
            radVerano.Location = new Point(97, 3);
            radVerano.Name = "radVerano";
            radVerano.Size = new Size(77, 22);
            radVerano.TabIndex = 2;
            radVerano.TabStop = true;
            radVerano.Text = "Verano";
            radVerano.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label5.Location = new Point(3, 158);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(64, 18);
            label5.TabIndex = 0;
            label5.Text = "Carrera";
            // 
            // comboBoxCarrera
            // 
            comboBoxCarrera.DropDownWidth = 350;
            comboBoxCarrera.FormattingEnabled = true;
            comboBoxCarrera.Items.AddRange(new object[] { "Ciberseguridad", "Ciencias de la Computación", "Desarrollo y Gestión de Software", "Redes Informáticas" });
            comboBoxCarrera.Location = new Point(3, 179);
            comboBoxCarrera.Name = "comboBoxCarrera";
            comboBoxCarrera.Size = new Size(244, 26);
            comboBoxCarrera.Sorted = true;
            comboBoxCarrera.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label7.Location = new Point(3, 213);
            label7.Margin = new Padding(3, 5, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(184, 18);
            label7.TabIndex = 5;
            label7.Text = "Términos y condiciones";
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Controls.Add(checkTerminos);
            flowLayoutPanel13.Controls.Add(checkNotificaciones);
            flowLayoutPanel13.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel13.Location = new Point(3, 234);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(250, 64);
            flowLayoutPanel13.TabIndex = 4;
            // 
            // checkTerminos
            // 
            checkTerminos.AutoSize = true;
            checkTerminos.Location = new Point(3, 3);
            checkTerminos.Name = "checkTerminos";
            checkTerminos.Size = new Size(158, 22);
            checkTerminos.TabIndex = 0;
            checkTerminos.Text = "Aceptar Términos";
            checkTerminos.UseVisualStyleBackColor = true;
            // 
            // checkNotificaciones
            // 
            checkNotificaciones.AutoSize = true;
            checkNotificaciones.Location = new Point(3, 31);
            checkNotificaciones.Name = "checkNotificaciones";
            checkNotificaciones.Size = new Size(206, 22);
            checkNotificaciones.TabIndex = 1;
            checkNotificaciones.Text = "Recibir Notificaciones";
            checkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.Controls.Add(BtnNuevo);
            flowLayoutPanel14.Controls.Add(BtnEditar);
            flowLayoutPanel14.Controls.Add(BtnGuardar);
            flowLayoutPanel14.Controls.Add(BtnEliminar);
            flowLayoutPanel14.Location = new Point(3, 304);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(250, 125);
            flowLayoutPanel14.TabIndex = 2;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnNuevo.Location = new Point(3, 3);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(94, 29);
            BtnNuevo.TabIndex = 3;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.PaleTurquoise;
            BtnEditar.FlatAppearance.BorderColor = Color.PaleTurquoise;
            BtnEditar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEditar.Location = new Point(103, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(94, 29);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.LightGreen;
            BtnGuardar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnGuardar.Location = new Point(3, 38);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.LightCoral;
            BtnEliminar.Font = new Font("Consolas", 9F, FontStyle.Bold);
            BtnEliminar.Location = new Point(103, 38);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 2;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(20, 10, 20, 10);
            groupBox2.Size = new Size(1078, 691);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "n";
            // 
            // MenuToolbar
            // 
            MenuToolbar.BackColor = SystemColors.ControlLight;
            MenuToolbar.ImageScalingSize = new Size(20, 20);
            MenuToolbar.Items.AddRange(new ToolStripItem[] { archivoMenuToolbarItem });
            MenuToolbar.Location = new Point(0, 0);
            MenuToolbar.Name = "MenuToolbar";
            MenuToolbar.Size = new Size(1078, 28);
            MenuToolbar.TabIndex = 4;
            MenuToolbar.Text = "menuStrip1";
            // 
            // archivoMenuToolbarItem
            // 
            archivoMenuToolbarItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoMenuToolbarItem, guardarMenuToolbarItem, editarToolStripMenuItem, eliminarToolStripMenuItem, reportesToolStripMenuItem, salirMenuToolbarItem });
            archivoMenuToolbarItem.Name = "archivoMenuToolbarItem";
            archivoMenuToolbarItem.Size = new Size(73, 24);
            archivoMenuToolbarItem.Text = "Archivo";
            // 
            // nuevoMenuToolbarItem
            // 
            nuevoMenuToolbarItem.Name = "nuevoMenuToolbarItem";
            nuevoMenuToolbarItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoMenuToolbarItem.Size = new Size(202, 26);
            nuevoMenuToolbarItem.Text = "Nuevo";
            nuevoMenuToolbarItem.Click += nuevoMenuToolbarItem_Click;
            // 
            // guardarMenuToolbarItem
            // 
            guardarMenuToolbarItem.Name = "guardarMenuToolbarItem";
            guardarMenuToolbarItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarMenuToolbarItem.Size = new Size(202, 26);
            guardarMenuToolbarItem.Text = "Guardar";
            guardarMenuToolbarItem.Click += guardarMenuToolbarItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            editarToolStripMenuItem.Size = new Size(202, 26);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            eliminarToolStripMenuItem.Size = new Size(202, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generalToolStripMenuItem, estudianteToolStripMenuItem, carreraToolStripMenuItem, jornadaToolStripMenuItem, rangoFechasToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            reportesToolStripMenuItem.Size = new Size(202, 26);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generalToolStripMenuItem
            // 
            generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            generalToolStripMenuItem.Size = new Size(151, 26);
            generalToolStripMenuItem.Text = "General";
            generalToolStripMenuItem.Click += generalToolStripMenuItem_Click;
            // 
            // estudianteToolStripMenuItem
            // 
            estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            estudianteToolStripMenuItem.Size = new Size(151, 26);
            estudianteToolStripMenuItem.Text = "Alumno";
            estudianteToolStripMenuItem.Click += estudianteToolStripMenuItem_Click;
            // 
            // carreraToolStripMenuItem
            // 
            carreraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ciberseguridadToolStripMenuItem, cienciasToolStripMenuItem, desarrolloYGestiónDeSoftwareToolStripMenuItem, redesInformáticasToolStripMenuItem });
            carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            carreraToolStripMenuItem.Size = new Size(151, 26);
            carreraToolStripMenuItem.Text = "Carrera";
            // 
            // ciberseguridadToolStripMenuItem
            // 
            ciberseguridadToolStripMenuItem.Name = "ciberseguridadToolStripMenuItem";
            ciberseguridadToolStripMenuItem.Size = new Size(307, 26);
            ciberseguridadToolStripMenuItem.Text = "Ciberseguridad";
            ciberseguridadToolStripMenuItem.Click += ciberseguridadToolStripMenuItem_Click;
            // 
            // cienciasToolStripMenuItem
            // 
            cienciasToolStripMenuItem.Name = "cienciasToolStripMenuItem";
            cienciasToolStripMenuItem.Size = new Size(307, 26);
            cienciasToolStripMenuItem.Text = "Ciencias de la computación";
            cienciasToolStripMenuItem.Click += cienciasToolStripMenuItem_Click;
            // 
            // desarrolloYGestiónDeSoftwareToolStripMenuItem
            // 
            desarrolloYGestiónDeSoftwareToolStripMenuItem.Name = "desarrolloYGestiónDeSoftwareToolStripMenuItem";
            desarrolloYGestiónDeSoftwareToolStripMenuItem.Size = new Size(307, 26);
            desarrolloYGestiónDeSoftwareToolStripMenuItem.Text = "Desarrollo y gestión de software";
            desarrolloYGestiónDeSoftwareToolStripMenuItem.Click += desarrolloYGestiónDeSoftwareToolStripMenuItem_Click;
            // 
            // redesInformáticasToolStripMenuItem
            // 
            redesInformáticasToolStripMenuItem.Name = "redesInformáticasToolStripMenuItem";
            redesInformáticasToolStripMenuItem.Size = new Size(307, 26);
            redesInformáticasToolStripMenuItem.Text = "Redes Informáticas";
            redesInformáticasToolStripMenuItem.Click += redesInformáticasToolStripMenuItem_Click;
            // 
            // jornadaToolStripMenuItem
            // 
            jornadaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { matutinoToolStripMenuItem, vesperinoToolStripMenuItem });
            jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            jornadaToolStripMenuItem.Size = new Size(151, 26);
            jornadaToolStripMenuItem.Text = "Jornada";
            // 
            // matutinoToolStripMenuItem
            // 
            matutinoToolStripMenuItem.Name = "matutinoToolStripMenuItem";
            matutinoToolStripMenuItem.Size = new Size(157, 26);
            matutinoToolStripMenuItem.Text = "Matutino";
            matutinoToolStripMenuItem.Click += matutinoToolStripMenuItem_Click;
            // 
            // vesperinoToolStripMenuItem
            // 
            vesperinoToolStripMenuItem.Name = "vesperinoToolStripMenuItem";
            vesperinoToolStripMenuItem.Size = new Size(157, 26);
            vesperinoToolStripMenuItem.Text = "Vesperino";
            vesperinoToolStripMenuItem.Click += vesperinoToolStripMenuItem_Click;
            // 
            // rangoFechasToolStripMenuItem
            // 
            rangoFechasToolStripMenuItem.Name = "rangoFechasToolStripMenuItem";
            rangoFechasToolStripMenuItem.Size = new Size(151, 26);
            rangoFechasToolStripMenuItem.Text = "PorFecha";
            rangoFechasToolStripMenuItem.Click += rangoFechasToolStripMenuItem_Click;
            // 
            // salirMenuToolbarItem
            // 
            salirMenuToolbarItem.Name = "salirMenuToolbarItem";
            salirMenuToolbarItem.Size = new Size(202, 26);
            salirMenuToolbarItem.Text = "Salir";
            salirMenuToolbarItem.Click += salirMenuToolbarItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1078, 691);
            Controls.Add(MenuToolbar);
            Controls.Add(groupBox2);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MenuToolbar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableGridAlumnos).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            flowLayoutPanel12.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel13.ResumeLayout(false);
            flowLayoutPanel13.PerformLayout();
            flowLayoutPanel14.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            MenuToolbar.ResumeLayout(false);
            MenuToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private TextBox BoxNombre;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel8;
        private RadioButton radISemestre;
        private RadioButton radIISemestre;
        private Label label5;
        private ComboBox comboBoxCarrera;
        private TextBox BoxCedula;
        private MenuStrip MenuToolbar;
        private ToolStripMenuItem archivoMenuToolbarItem;
        private ToolStripMenuItem nuevoMenuToolbarItem;
        private ToolStripMenuItem guardarMenuToolbarItem;
        private ToolStripMenuItem salirMenuToolbarItem;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label13;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel10;
        private TextBox BoxUsuario;
        private TextBox BoxContrasena;
        private FlowLayoutPanel flowLayoutPanel4;
        private RadioButton radMatutino;
        private RadioButton radVesperina;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label label6;
        private Label label1;
        private RadioButton radVerano;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private FlowLayoutPanel flowLayoutPanel13;
        private Label label7;
        private CheckBox checkTerminos;
        private CheckBox checkNotificaciones;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem generalToolStripMenuItem;
        private ToolStripMenuItem carreraToolStripMenuItem;
        private ToolStripMenuItem jornadaToolStripMenuItem;
        private ToolStripMenuItem rangoFechasToolStripMenuItem;
        private ToolStripMenuItem matutinoToolStripMenuItem;
        private ToolStripMenuItem vesperinoToolStripMenuItem;
        private ToolStripMenuItem estudianteToolStripMenuItem;
        private ToolStripMenuItem ciberseguridadToolStripMenuItem;
        private ToolStripMenuItem cienciasToolStripMenuItem;
        private ToolStripMenuItem desarrolloYGestiónDeSoftwareToolStripMenuItem;
        private ToolStripMenuItem redesInformáticasToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel14;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private DataGridView TableGridAlumnos;
    }
}
