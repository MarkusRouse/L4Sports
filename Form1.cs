using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEgresoEMT
{
    /*
     * public class User
        {
            string nombreUsuario, email, contraseña, tipoUsuario;

            public string Nombre
            {
                set
                {
                    nombreUsuario = value;
                }
                get
                {
                    return nombreUsuario;
                }
            }

            public string Email
            {
                set
                {
                    email = value;
                }
                get
                {
                    return email;
                }
            }

            public string Contraseña
            {
                set
                {
                    contraseña = value;
                }
                get
                {
                    return contraseña;
                }
            }

            string TipoUsuario
            {
                set
                {
                    tipoUsuario = value;
                }
                get
                {
                    return tipoUsuario;
                }
            }

            public User(string _nombre, string _email, string _contraseña, string _tipoUsuario)
            {
                nombreUsuario = _nombre;
                email = _email;
                contraseña = _contraseña;
                tipoUsuario = _tipoUsuario;
            }
        }
     * */
    public partial class Form1 : Form
    {
        string nombre = "admin", contraseña = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (nombre == txtNombre.Text && contraseña == txtContraseña.Text)
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                txtContraseña.Text = "";
            }
        }
    }
}
