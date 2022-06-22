using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAplication
{
    public partial class Form2 : Form
    {
        
        List<User> listaUsuarios = new List<User>();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlAdmAdministradores_Paint(object sender, PaintEventArgs e)
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
        public User(string nombre,string contraseña,string mail, string tipo_usuario)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.mail = mail;
            this.tipo_usuario = tipo_usuario;
        }
    }
}
