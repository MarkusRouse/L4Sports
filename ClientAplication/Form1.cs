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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearUsuarios();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                if ((txtboxNombre.Text == listaUsuarios[i].Nombre || txtboxNombre.Text == listaUsuarios[i].Mail) && txtboxContraseña.Text == listaUsuarios[i].Contraseña)
                {
                    MessageBox.Show("Bienvenido");
                    Form2 frm2 = new Form2();
                    this.Hide();
                    frm2.Show();

                    break;
                }
                else if (i + 1 == listaUsuarios.Count())
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        public void CreateUser(string nombre,string contraseña,string mail)
        {
            User user1 = new User(nombre,contraseña,mail);
            listaUsuarios.Add(user1);
        }
        public void CrearUsuarios()
        {
            CreateUser("user", "user", "correo@gmail.com");
            CreateUser("user1", "user1", "correo1@gmail.com");
            CreateUser("user2", "user2", "correo2@gmail.com");
            CreateUser("user3", "user3", "correo3@gmail.com");
            CreateUser("user4", "user4", "correo4@gmail.com");
            CreateUser("user5", "user5", "correo5@gmail.com");
        }

        private void btnIniciarInvitado_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
    class User
    {
        string nombre, contraseña, mail;

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

        public User()
        {

        }
        public User(string nombre, string contraseña, string mail)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.mail = mail;
        }
    }
}
