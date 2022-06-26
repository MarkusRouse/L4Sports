using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAplication
{
    class Admin
    {
        private List<User> listaAdmins = new List<User>();
        public void AddAdmin(TextBox txtboxContraseñaAdmin,TextBox txtboxNombreAdmin,ListBox lstboxAdministradores)
        {
            if ((txtboxContraseñaAdmin.Text).Trim() != "" && (txtboxNombreAdmin.Text).Trim() != "")
            {
                if (listaAdmins.Count == 0)
                {
                    User admin = new User(txtboxNombreAdmin.Text, txtboxContraseñaAdmin.Text);
                    listaAdmins.Add(admin);
                    lstboxAdministradores.Items.Add(admin.Datos1());
                }
                else
                {
                    foreach (User usuario in listaAdmins)
                    {
                        if (usuario.Nombre == txtboxNombreAdmin.Text)
                        {
                            MessageBox.Show("El administrador ya existe, por favor ingrese uno con otro nombre");
                            break;
                        }
                        else if (listaAdmins.Last() == usuario)
                        {
                            User admin = new User(txtboxNombreAdmin.Text, txtboxContraseñaAdmin.Text);
                            listaAdmins.Add(admin);
                            lstboxAdministradores.Items.Add(admin.Datos1());
                            break;
                        }
                    }
                }
            }
            else
            {
                if (txtboxNombreAdmin.Text.Trim() == "")
                {
                    txtboxNombreAdmin.Clear();
                }
                if (txtboxContraseñaAdmin.Text.Trim() == "")
                {
                    txtboxContraseñaAdmin.Clear();
                }
                MessageBox.Show("No debe dejar ninún espacio en blanco");
            }
        }
        public void RemoveAdmin(ListBox lstboxAdministradores)
        {
            if (lstboxAdministradores.SelectedIndex != -1)
            {
                lstboxAdministradores.Items.Remove(lstboxAdministradores.SelectedItem);
                listaAdmins.RemoveAt(lstboxAdministradores.SelectedIndex + 1);
            }
        }
    }
}
