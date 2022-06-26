using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAplication
{
    class Autentication
    {
        private string nomAdmin = "admin", passAdmin = "admin";
        public void Login(string nombreAdmin,string contraseñaAdmin,Form1 frm1,Form2 frm2)
        {
            if ((nombreAdmin.Trim() != "" && contraseñaAdmin.Trim() != ""))
            {
                if (nombreAdmin == nomAdmin && contraseñaAdmin == passAdmin)
                {
                    MessageBox.Show("Bienvenido");
                    Form2 ventanaAdmin = new Form2();
                    frm1.Hide();
                    frm2.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Error, no debe dejar ningún espacio en blanco");
            }
        }
    }
}
