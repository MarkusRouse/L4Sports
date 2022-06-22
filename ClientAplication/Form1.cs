using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAplication
{
 
    public partial class Form1 : Form
    {
        List<User> listaUsuarios = new List<User>();
        string nombre = "admin", contraseña = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtboxNombre.Text == nombre && txtboxContraseña.Text == contraseña)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
    class User
    {
        string nombre, contraseña, mail, tipo_usuario;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
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

        public string Mail
        {
            set
            {
                mail = value;
            }
            get
            {
                return mail;
            }
        }

        public string Tipo_usuario
        {
            set
            {
                tipo_usuario = value;
            }
            get
            {
                return tipo_usuario;
            }
        }

        public User()
        {

        }
        public User(string nombre, string contraseña, string mail, string tipo_usuario)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.mail = mail;
            this.tipo_usuario = tipo_usuario;
        }
    }
}
