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
        Autentication autentication = new Autentication();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
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
    }
}
