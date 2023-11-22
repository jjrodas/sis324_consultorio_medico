namespace CpConsultorioMedico
{
    partial class FrmCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCitas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtQuirofano = new System.Windows.Forms.TextBox();
            this.lblQuirofano = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtFechaCita = new System.Windows.Forms.TextBox();
            this.txtHoraCita = new System.Windows.Forms.TextBox();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxListaPacientes = new System.Windows.Forms.GroupBox();
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlBarraTitulo.Controls.Add(this.label1);
            this.pnlBarraTitulo.Controls.Add(this.ptbMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.ptbCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(900, 38);
            this.pnlBarraTitulo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "::: Citas - Consultorio Médico :::";
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(821, 7);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 1;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(863, 7);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(25, 25);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 0;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.btnCitas);
            this.pnlMenuVertical.Controls.Add(this.panel2);
            this.pnlMenuVertical.Controls.Add(this.btnMedicos);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.btnPacientes);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 38);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(200, 516);
            this.pnlMenuVertical.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 40);
            this.panel3.TabIndex = 6;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Image = ((System.Drawing.Image)(resources.GetObject("btnCitas.Image")));
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(4, 270);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(196, 40);
            this.btnCitas.TabIndex = 5;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 40);
            this.panel2.TabIndex = 4;
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicos.Image")));
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Location = new System.Drawing.Point(4, 224);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(196, 40);
            this.btnMedicos.TabIndex = 3;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(4, 178);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(196, 40);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.pnlContenedor.Controls.Add(this.gbxDatos);
            this.pnlContenedor.Controls.Add(this.pnlAcciones);
            this.pnlContenedor.Controls.Add(this.gbxListaPacientes);
            this.pnlContenedor.Controls.Add(this.btnBuscar);
            this.pnlContenedor.Controls.Add(this.lblBusqueda);
            this.pnlContenedor.Controls.Add(this.txtParametro);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(700, 516);
            this.pnlContenedor.TabIndex = 51;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtCuenta);
            this.gbxDatos.Controls.Add(this.lblCuenta);
            this.gbxDatos.Controls.Add(this.txtQuirofano);
            this.gbxDatos.Controls.Add(this.lblQuirofano);
            this.gbxDatos.Controls.Add(this.txtMotivo);
            this.gbxDatos.Controls.Add(this.lblMotivo);
            this.gbxDatos.Controls.Add(this.txtFechaCita);
            this.gbxDatos.Controls.Add(this.txtHoraCita);
            this.gbxDatos.Controls.Add(this.lblFechaCita);
            this.gbxDatos.Controls.Add(this.lblHoraCita);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.Color.White;
            this.gbxDatos.Location = new System.Drawing.Point(7, 322);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(683, 187);
            this.gbxDatos.TabIndex = 53;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Detalles de las citas";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(173, 144);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(163, 26);
            this.txtCuenta.TabIndex = 3;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(24, 151);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(53, 18);
            this.lblCuenta.TabIndex = 38;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // txtQuirofano
            // 
            this.txtQuirofano.Location = new System.Drawing.Point(472, 23);
            this.txtQuirofano.MaxLength = 250;
            this.txtQuirofano.Name = "txtQuirofano";
            this.txtQuirofano.Size = new System.Drawing.Size(163, 26);
            this.txtQuirofano.TabIndex = 4;
            // 
            // lblQuirofano
            // 
            this.lblQuirofano.AutoSize = true;
            this.lblQuirofano.Location = new System.Drawing.Point(368, 31);
            this.lblQuirofano.Name = "lblQuirofano";
            this.lblQuirofano.Size = new System.Drawing.Size(75, 18);
            this.lblQuirofano.TabIndex = 34;
            this.lblQuirofano.Text = "Quirófano:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(173, 103);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(163, 26);
            this.txtMotivo.TabIndex = 2;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(23, 110);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(114, 18);
            this.lblMotivo.TabIndex = 32;
            this.lblMotivo.Text = "Motivo de la Cita:";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Location = new System.Drawing.Point(173, 62);
            this.txtFechaCita.MaxLength = 250;
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Size = new System.Drawing.Size(163, 26);
            this.txtFechaCita.TabIndex = 1;
            // 
            // txtHoraCita
            // 
            this.txtHoraCita.Location = new System.Drawing.Point(173, 24);
            this.txtHoraCita.MaxLength = 250;
            this.txtHoraCita.Name = "txtHoraCita";
            this.txtHoraCita.Size = new System.Drawing.Size(163, 26);
            this.txtHoraCita.TabIndex = 0;
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Location = new System.Drawing.Point(23, 69);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(110, 18);
            this.lblFechaCita.TabIndex = 14;
            this.lblFechaCita.Text = "Fecha de la Cita:";
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Location = new System.Drawing.Point(24, 31);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(104, 18);
            this.lblHoraCita.TabIndex = 8;
            this.lblHoraCita.Text = "Hora de la Cita:";
            this.lblHoraCita.Click += new System.EventHandler(this.lblCedulaIdentidad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(513, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(412, 139);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 42);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(89, 267);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(518, 48);
            this.pnlAcciones.TabIndex = 52;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(390, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(265, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar \r\nCita";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(146, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 42);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar \r\nCita";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(23, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 42);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nueva \r\nCita";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxListaPacientes
            // 
            this.gbxListaPacientes.Controls.Add(this.dgvListaPacientes);
            this.gbxListaPacientes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaPacientes.ForeColor = System.Drawing.Color.White;
            this.gbxListaPacientes.Location = new System.Drawing.Point(3, 55);
            this.gbxListaPacientes.Name = "gbxListaPacientes";
            this.gbxListaPacientes.Size = new System.Drawing.Size(694, 207);
            this.gbxListaPacientes.TabIndex = 51;
            this.gbxListaPacientes.TabStop = false;
            this.gbxListaPacientes.Text = "Lista de citas";
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.AllowUserToAddRows = false;
            this.dgvListaPacientes.AllowUserToDeleteRows = false;
            this.dgvListaPacientes.AllowUserToResizeColumns = false;
            this.dgvListaPacientes.AllowUserToResizeRows = false;
            this.dgvListaPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(4, 17);
            this.dgvListaPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaPacientes.MultiSelect = false;
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.ReadOnly = true;
            this.dgvListaPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvListaPacientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPacientes.Size = new System.Drawing.Size(683, 182);
            this.dgvListaPacientes.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(587, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 42);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(13, 8);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(287, 18);
            this.lblBusqueda.TabIndex = 49;
            this.lblBusqueda.Text = "Buscar por cédula de indentidad del paciente:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(16, 29);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(469, 20);
            this.txtParametro.TabIndex = 48;
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Citas - Consultorio Médico :::";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCita_FormClosing);
            this.Load += new System.EventHandler(this.FrmCita_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtQuirofano;
        private System.Windows.Forms.Label lblQuirofano;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtFechaCita;
        private System.Windows.Forms.TextBox txtHoraCita;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxListaPacientes;
        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
    }
}