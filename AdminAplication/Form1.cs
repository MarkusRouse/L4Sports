using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAplication
{

    public partial class Form1 : Form
    {

        ListaDeUsuarios listaUsuarios = new ListaDeUsuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user1 = new User("admin","admin");
            listaUsuarios.GetLista.Add(user1);
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listaUsuarios.GetLista.Count(); i++)
            {
                if (txtboxNombre.Text == listaUsuarios.GetLista[i].Nombre && txtboxContraseña.Text == listaUsuarios.GetLista[i].Contraseña)
                {
                    MessageBox.Show("Bienvenido");
                    Form2 ventanaAdmin = new Form2();
                    this.Hide();
                    ventanaAdmin.Show();
                }
                else if (i + 1 == listaUsuarios.GetLista.Count())
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
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
