using System;
using System.IO;
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
        Client client = new Client();
        Admin admin = new Admin();
        Advertising advertising = new Advertising();
        Form1 ventanaLogin = new Form1();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();   
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        openFileDialog1.Multiselect = true;
        openFileDialog1.Filter = "Image Files (JPG,PNG)|*.JPG;*.PNG;";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            client.AddClient(txtboxContraseñaUsuario, txtboxNombreUsuario, txtboxMailUsuario, lstboxUsuarios);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlAdmAdministradores_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void lstboxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            client.RemoveClient(lstboxUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAdmUsuario.Visible = true;
            pnlAdmAdministradores.Visible = false;
            pnlAdmPublicidad.Visible = false;

        }

        private void pnlAdmInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdmAdministradores.Visible = true;
            pnlAdmUsuario.Visible = false;
            pnlAdmPublicidad.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cerrando sesión");
            this.Hide();
            ventanaLogin.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAñadirAdministrador_Click(object sender, EventArgs e)
        {
            admin.AddAdmin(txtboxContraseñaAdmin, txtboxNombreAdmin, lstboxAdministradores);
        }

        private void btnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            admin.RemoveAdmin(lstboxAdministradores);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlAdmPublicidad.Visible = true;
            pnlAdmAdministradores.Visible = false;
            pnlAdmUsuario.Visible = false;
        }
        private void btnAgregarPublicidad_Click(object sender, EventArgs e)
        {
            advertising.AddAd(lstboxPublicidad,openFileDialog1);
        }

        private void lstboxPublicidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxPublicidad.SelectedItem != null)
            {
                if (lstboxPublicidad.SelectedIndex != -1)
                {
                    pctboxPublicidad.ImageLocation = lstboxPublicidad.SelectedItem.ToString();
                }
            }
        }
       
        private void btnEliminarPublicidad_Click(object sender, EventArgs e)
        {
            advertising.RemoveAd(lstboxPublicidad,pctboxPublicidad);
        }
        private void pctboxPublicidad_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxMailUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
