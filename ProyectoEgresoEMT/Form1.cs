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

namespace ProyectoEgresoEMT
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
                Form2 ventanaAdmin = new Form2();
                this.Hide();
                ventanaAdmin.Show();
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
}
