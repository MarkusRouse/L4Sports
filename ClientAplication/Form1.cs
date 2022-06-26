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
        Autentication autentication = new Autentication();
        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autentication.CrearUsuarios();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            autentication.Login(txtboxNombre.Text,txtboxContraseña.Text,this,frm2);
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
        private void btnIniciarInvitado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Show();
        }
    }

}
