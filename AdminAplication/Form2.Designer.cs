namespace AdminAplication
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlAdmUsuario = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxMailUsuario = new System.Windows.Forms.TextBox();
            this.txtboxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lstboxUsuarios = new System.Windows.Forms.ListBox();
            this.pnlAdmAdministradores = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.txtboxNombreAdmin = new System.Windows.Forms.TextBox();
            this.btnEliminarAdministrador = new System.Windows.Forms.Button();
            this.btnAñadirAdministrador = new System.Windows.Forms.Button();
            this.lstboxAdministradores = new System.Windows.Forms.ListBox();
            this.pnlAdmPublicidad = new System.Windows.Forms.Panel();
            this.btnAgregarPublicidad = new System.Windows.Forms.Button();
            this.btnEliminarPublicidad = new System.Windows.Forms.Button();
            this.pctboxPublicidad = new System.Windows.Forms.PictureBox();
            this.lstboxPublicidad = new System.Windows.Forms.ListBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlAdmUsuario.SuspendLayout();
            this.pnlAdmAdministradores.SuspendLayout();
            this.pnlAdmPublicidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxPublicidad)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Administrar Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Administrar Administradores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administrar publicidad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlAdmUsuario
            // 
            this.pnlAdmUsuario.Controls.Add(this.label3);
            this.pnlAdmUsuario.Controls.Add(this.label2);
            this.pnlAdmUsuario.Controls.Add(this.label1);
            this.pnlAdmUsuario.Controls.Add(this.txtboxMailUsuario);
            this.pnlAdmUsuario.Controls.Add(this.txtboxContraseñaUsuario);
            this.pnlAdmUsuario.Controls.Add(this.txtboxNombreUsuario);
            this.pnlAdmUsuario.Controls.Add(this.btnEliminarUsuario);
            this.pnlAdmUsuario.Controls.Add(this.button5);
            this.pnlAdmUsuario.Controls.Add(this.lstboxUsuarios);
            this.pnlAdmUsuario.Location = new System.Drawing.Point(150, 2);
            this.pnlAdmUsuario.Name = "pnlAdmUsuario";
            this.pnlAdmUsuario.Size = new System.Drawing.Size(648, 386);
            this.pnlAdmUsuario.TabIndex = 5;
            this.pnlAdmUsuario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtboxMailUsuario
            // 
            this.txtboxMailUsuario.Location = new System.Drawing.Point(150, 248);
            this.txtboxMailUsuario.Name = "txtboxMailUsuario";
            this.txtboxMailUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxMailUsuario.TabIndex = 5;
            // 
            // txtboxContraseñaUsuario
            // 
            this.txtboxContraseñaUsuario.Location = new System.Drawing.Point(150, 210);
            this.txtboxContraseñaUsuario.Name = "txtboxContraseñaUsuario";
            this.txtboxContraseñaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxContraseñaUsuario.TabIndex = 4;
            // 
            // txtboxNombreUsuario
            // 
            this.txtboxNombreUsuario.Location = new System.Drawing.Point(150, 172);
            this.txtboxNombreUsuario.Name = "txtboxNombreUsuario";
            this.txtboxNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombreUsuario.TabIndex = 3;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(242, 3);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Añadir usuario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lstboxUsuarios
            // 
            this.lstboxUsuarios.FormattingEnabled = true;
            this.lstboxUsuarios.Location = new System.Drawing.Point(349, 2);
            this.lstboxUsuarios.Name = "lstboxUsuarios";
            this.lstboxUsuarios.Size = new System.Drawing.Size(299, 381);
            this.lstboxUsuarios.TabIndex = 0;
            this.lstboxUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstboxUsuarios_SelectedIndexChanged);
            // 
            // pnlAdmAdministradores
            // 
            this.pnlAdmAdministradores.Controls.Add(this.label5);
            this.pnlAdmAdministradores.Controls.Add(this.label6);
            this.pnlAdmAdministradores.Controls.Add(this.txtboxContraseñaAdmin);
            this.pnlAdmAdministradores.Controls.Add(this.txtboxNombreAdmin);
            this.pnlAdmAdministradores.Controls.Add(this.btnEliminarAdministrador);
            this.pnlAdmAdministradores.Controls.Add(this.btnAñadirAdministrador);
            this.pnlAdmAdministradores.Controls.Add(this.lstboxAdministradores);
            this.pnlAdmAdministradores.Location = new System.Drawing.Point(150, 2);
            this.pnlAdmAdministradores.Name = "pnlAdmAdministradores";
            this.pnlAdmAdministradores.Size = new System.Drawing.Size(651, 386);
            this.pnlAdmAdministradores.TabIndex = 9;
            this.pnlAdmAdministradores.Visible = false;
            this.pnlAdmAdministradores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdmAdministradores_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre";
            // 
            // txtboxContraseñaAdmin
            // 
            this.txtboxContraseñaAdmin.Location = new System.Drawing.Point(150, 239);
            this.txtboxContraseñaAdmin.Name = "txtboxContraseñaAdmin";
            this.txtboxContraseñaAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtboxContraseñaAdmin.TabIndex = 4;
            // 
            // txtboxNombreAdmin
            // 
            this.txtboxNombreAdmin.Location = new System.Drawing.Point(150, 201);
            this.txtboxNombreAdmin.Name = "txtboxNombreAdmin";
            this.txtboxNombreAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtboxNombreAdmin.TabIndex = 3;
            // 
            // btnEliminarAdministrador
            // 
            this.btnEliminarAdministrador.Location = new System.Drawing.Point(221, 3);
            this.btnEliminarAdministrador.Name = "btnEliminarAdministrador";
            this.btnEliminarAdministrador.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarAdministrador.TabIndex = 2;
            this.btnEliminarAdministrador.Text = "Eliminar administrador";
            this.btnEliminarAdministrador.UseVisualStyleBackColor = true;
            this.btnEliminarAdministrador.Click += new System.EventHandler(this.btnEliminarAdministrador_Click);
            // 
            // btnAñadirAdministrador
            // 
            this.btnAñadirAdministrador.Location = new System.Drawing.Point(150, 277);
            this.btnAñadirAdministrador.Name = "btnAñadirAdministrador";
            this.btnAñadirAdministrador.Size = new System.Drawing.Size(132, 23);
            this.btnAñadirAdministrador.TabIndex = 1;
            this.btnAñadirAdministrador.Text = "Añadir administrador";
            this.btnAñadirAdministrador.UseVisualStyleBackColor = true;
            this.btnAñadirAdministrador.Click += new System.EventHandler(this.btnAñadirAdministrador_Click);
            // 
            // lstboxAdministradores
            // 
            this.lstboxAdministradores.FormattingEnabled = true;
            this.lstboxAdministradores.Location = new System.Drawing.Point(349, 2);
            this.lstboxAdministradores.Name = "lstboxAdministradores";
            this.lstboxAdministradores.Size = new System.Drawing.Size(302, 381);
            this.lstboxAdministradores.TabIndex = 0;
            // 
            // pnlAdmPublicidad
            // 
            this.pnlAdmPublicidad.Controls.Add(this.btnAgregarPublicidad);
            this.pnlAdmPublicidad.Controls.Add(this.btnEliminarPublicidad);
            this.pnlAdmPublicidad.Controls.Add(this.pctboxPublicidad);
            this.pnlAdmPublicidad.Controls.Add(this.lstboxPublicidad);
            this.pnlAdmPublicidad.Location = new System.Drawing.Point(150, 5);
            this.pnlAdmPublicidad.Name = "pnlAdmPublicidad";
            this.pnlAdmPublicidad.Size = new System.Drawing.Size(654, 386);
            this.pnlAdmPublicidad.TabIndex = 8;
            // 
            // btnAgregarPublicidad
            // 
            this.btnAgregarPublicidad.Location = new System.Drawing.Point(362, 195);
            this.btnAgregarPublicidad.Name = "btnAgregarPublicidad";
            this.btnAgregarPublicidad.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarPublicidad.TabIndex = 3;
            this.btnAgregarPublicidad.Text = "Agregar imagen";
            this.btnAgregarPublicidad.UseVisualStyleBackColor = true;
            this.btnAgregarPublicidad.Click += new System.EventHandler(this.btnAgregarPublicidad_Click);
            // 
            // btnEliminarPublicidad
            // 
            this.btnEliminarPublicidad.Location = new System.Drawing.Point(538, 196);
            this.btnEliminarPublicidad.Name = "btnEliminarPublicidad";
            this.btnEliminarPublicidad.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarPublicidad.TabIndex = 2;
            this.btnEliminarPublicidad.Text = "Eliminar imagen";
            this.btnEliminarPublicidad.UseVisualStyleBackColor = true;
            this.btnEliminarPublicidad.Click += new System.EventHandler(this.btnEliminarPublicidad_Click);
            // 
            // pctboxPublicidad
            // 
            this.pctboxPublicidad.Location = new System.Drawing.Point(349, 0);
            this.pctboxPublicidad.Name = "pctboxPublicidad";
            this.pctboxPublicidad.Size = new System.Drawing.Size(302, 189);
            this.pctboxPublicidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxPublicidad.TabIndex = 0;
            this.pctboxPublicidad.TabStop = false;
            this.pctboxPublicidad.Click += new System.EventHandler(this.pctboxPublicidad_Click);
            // 
            // lstboxPublicidad
            // 
            this.lstboxPublicidad.FormattingEnabled = true;
            this.lstboxPublicidad.Location = new System.Drawing.Point(6, -3);
            this.lstboxPublicidad.Name = "lstboxPublicidad";
            this.lstboxPublicidad.Size = new System.Drawing.Size(337, 368);
            this.lstboxPublicidad.TabIndex = 1;
            this.lstboxPublicidad.SelectedIndexChanged += new System.EventHandler(this.lstboxPublicidad_SelectedIndexChanged);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(0, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(144, 23);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pnlAdmPublicidad);
            this.Controls.Add(this.pnlAdmAdministradores);
            this.Controls.Add(this.pnlAdmUsuario);
            this.Name = "Form2";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlAdmUsuario.ResumeLayout(false);
            this.pnlAdmUsuario.PerformLayout();
            this.pnlAdmAdministradores.ResumeLayout(false);
            this.pnlAdmAdministradores.PerformLayout();
            this.pnlAdmPublicidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxPublicidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlAdmUsuario;
        private System.Windows.Forms.ListBox lstboxUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxMailUsuario;
        private System.Windows.Forms.TextBox txtboxContraseñaUsuario;
        private System.Windows.Forms.TextBox txtboxNombreUsuario;
        private System.Windows.Forms.Panel pnlAdmAdministradores;
        private System.Windows.Forms.Button btnEliminarAdministrador;
        private System.Windows.Forms.ListBox lstboxAdministradores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxContraseñaAdmin;
        private System.Windows.Forms.TextBox txtboxNombreAdmin;
        private System.Windows.Forms.Button btnAñadirAdministrador;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlAdmPublicidad;
        private System.Windows.Forms.Button btnAgregarPublicidad;
        private System.Windows.Forms.Button btnEliminarPublicidad;
        private System.Windows.Forms.ListBox lstboxPublicidad;
        private System.Windows.Forms.PictureBox pctboxPublicidad;
    }
}