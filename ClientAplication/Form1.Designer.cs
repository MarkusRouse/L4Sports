﻿namespace ClientAplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarInvitado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(189, 195);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(97, 23);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(176, 120);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(132, 20);
            this.txtboxNombre.TabIndex = 7;
            this.txtboxNombre.TextChanged += new System.EventHandler(this.txtboxNombre_TextChanged);
            // 
            // txtboxContraseña
            // 
            this.txtboxContraseña.Location = new System.Drawing.Point(176, 159);
            this.txtboxContraseña.Name = "txtboxContraseña";
            this.txtboxContraseña.PasswordChar = '*';
            this.txtboxContraseña.Size = new System.Drawing.Size(132, 20);
            this.txtboxContraseña.TabIndex = 8;
            // 
            // btnIniciarInvitado
            // 
            this.btnIniciarInvitado.Location = new System.Drawing.Point(395, 322);
            this.btnIniciarInvitado.Name = "btnIniciarInvitado";
            this.btnIniciarInvitado.Size = new System.Drawing.Size(97, 23);
            this.btnIniciarInvitado.TabIndex = 9;
            this.btnIniciarInvitado.Text = "Invitado";
            this.btnIniciarInvitado.UseVisualStyleBackColor = true;
            this.btnIniciarInvitado.Click += new System.EventHandler(this.btnIniciarInvitado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 357);
            this.Controls.Add(this.btnIniciarInvitado);
            this.Controls.Add(this.txtboxContraseña);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxContraseña;
        private System.Windows.Forms.Button btnIniciarInvitado;
    }
}

