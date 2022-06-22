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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlAdmUsuario.SuspendLayout();
            this.pnlAdmAdministradores.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Administrar Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-3, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Administrar Administradores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-3, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administrar publicidad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-3, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
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
            this.pnlAdmUsuario.Enabled = false;
            this.pnlAdmUsuario.Location = new System.Drawing.Point(147, 5);
            this.pnlAdmUsuario.Name = "pnlAdmUsuario";
            this.pnlAdmUsuario.Size = new System.Drawing.Size(651, 386);
            this.pnlAdmUsuario.TabIndex = 5;
            this.pnlAdmUsuario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtboxMailUsuario
            // 
            this.txtboxMailUsuario.Location = new System.Drawing.Point(74, 261);
            this.txtboxMailUsuario.Name = "txtboxMailUsuario";
            this.txtboxMailUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxMailUsuario.TabIndex = 5;
            // 
            // txtboxContraseñaUsuario
            // 
            this.txtboxContraseñaUsuario.Location = new System.Drawing.Point(74, 223);
            this.txtboxContraseñaUsuario.Name = "txtboxContraseñaUsuario";
            this.txtboxContraseñaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxContraseñaUsuario.TabIndex = 4;
            // 
            // txtboxNombreUsuario
            // 
            this.txtboxNombreUsuario.Location = new System.Drawing.Point(74, 185);
            this.txtboxNombreUsuario.Name = "txtboxNombreUsuario";
            this.txtboxNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombreUsuario.TabIndex = 3;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(245, 7);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 296);
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
            this.lstboxUsuarios.Location = new System.Drawing.Point(352, 3);
            this.lstboxUsuarios.Name = "lstboxUsuarios";
            this.lstboxUsuarios.Size = new System.Drawing.Size(299, 381);
            this.lstboxUsuarios.TabIndex = 0;
            // 
            // pnlAdmAdministradores
            // 
            this.pnlAdmAdministradores.Controls.Add(this.label5);
            this.pnlAdmAdministradores.Controls.Add(this.label6);
            this.pnlAdmAdministradores.Controls.Add(this.txtboxContraseñaAdmin);
            this.pnlAdmAdministradores.Controls.Add(this.txtboxNombreAdmin);
            this.pnlAdmAdministradores.Controls.Add(this.btnEliminarAdministrador);
            this.pnlAdmAdministradores.Controls.Add(this.btnAñadirAdministrador);
            this.pnlAdmAdministradores.Controls.Add(this.listBox1);
            this.pnlAdmAdministradores.Enabled = false;
            this.pnlAdmAdministradores.Location = new System.Drawing.Point(150, 5);
            this.pnlAdmAdministradores.Name = "pnlAdmAdministradores";
            this.pnlAdmAdministradores.Size = new System.Drawing.Size(651, 386);
            this.pnlAdmAdministradores.TabIndex = 9;
            this.pnlAdmAdministradores.Visible = false;
            this.pnlAdmAdministradores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdmAdministradores_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre";
            // 
            // txtboxContraseñaAdmin
            // 
            this.txtboxContraseñaAdmin.Location = new System.Drawing.Point(89, 249);
            this.txtboxContraseñaAdmin.Name = "txtboxContraseñaAdmin";
            this.txtboxContraseñaAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtboxContraseñaAdmin.TabIndex = 4;
            // 
            // txtboxNombreAdmin
            // 
            this.txtboxNombreAdmin.Location = new System.Drawing.Point(89, 211);
            this.txtboxNombreAdmin.Name = "txtboxNombreAdmin";
            this.txtboxNombreAdmin.Size = new System.Drawing.Size(132, 20);
            this.txtboxNombreAdmin.TabIndex = 3;
            // 
            // btnEliminarAdministrador
            // 
            this.btnEliminarAdministrador.Location = new System.Drawing.Point(224, 7);
            this.btnEliminarAdministrador.Name = "btnEliminarAdministrador";
            this.btnEliminarAdministrador.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarAdministrador.TabIndex = 2;
            this.btnEliminarAdministrador.Text = "Eliminar administrador";
            this.btnEliminarAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnAñadirAdministrador
            // 
            this.btnAñadirAdministrador.Location = new System.Drawing.Point(89, 287);
            this.btnAñadirAdministrador.Name = "btnAñadirAdministrador";
            this.btnAñadirAdministrador.Size = new System.Drawing.Size(132, 23);
            this.btnAñadirAdministrador.TabIndex = 1;
            this.btnAñadirAdministrador.Text = "Añadir administrador";
            this.btnAñadirAdministrador.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(352, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 381);
            this.listBox1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAdmAdministradores);
            this.Controls.Add(this.pnlAdmUsuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlAdmUsuario.ResumeLayout(false);
            this.pnlAdmUsuario.PerformLayout();
            this.pnlAdmAdministradores.ResumeLayout(false);
            this.pnlAdmAdministradores.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxContraseñaAdmin;
        private System.Windows.Forms.TextBox txtboxNombreAdmin;
        private System.Windows.Forms.Button btnEliminarAdministrador;
        private System.Windows.Forms.Button btnAñadirAdministrador;
        private System.Windows.Forms.ListBox listBox1;
    }
}