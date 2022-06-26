using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAplication
{
    class Client
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        public void AddClient(TextBox txtboxContraseñaUsuario,TextBox txtboxNombreUsuario,TextBox txtboxMailUsuario,ListBox lstboxUsuarios)
        {
            if ((txtboxContraseñaUsuario.Text).Trim() != "" && (txtboxNombreUsuario.Text).Trim() != "" && (txtboxMailUsuario.Text).Trim() != "")
            {
                if (txtboxMailUsuario.Text.Contains("@gmail.com") || txtboxMailUsuario.Text.Contains("@hotmail.com") || txtboxMailUsuario.Text.Contains("@outlook.com"))
                {
                    if (listaClientes.Count == 0)
                    {
                        Cliente cliente = new Cliente(txtboxNombreUsuario.Text, txtboxContraseñaUsuario.Text, txtboxMailUsuario.Text);
                        listaClientes.Add(cliente);
                        lstboxUsuarios.Items.Add(cliente.Datos2());
                    }
                    else
                    {
                        foreach (Cliente usuario in listaClientes)
                        {
                            if ((usuario.Nombre == txtboxNombreUsuario.Text && usuario.Mail == txtboxMailUsuario.Text))
                            {
                                MessageBox.Show("Ese usuario ya existe, por favor ingrese un nuevo usuario con otras características");
                                break;
                            }
                            else if (usuario.Nombre == txtboxNombreUsuario.Text)
                            {
                                MessageBox.Show("Ya existe un usuario con ese nombre, por favor ingrese uno que no se esté usado");
                                break;
                            }
                            else if (usuario.Mail == txtboxMailUsuario.Text)
                            {
                                MessageBox.Show("Ya existe un usuario con ese correo electrónico, por favor ingrese un usuario con otro correo");
                                break;
                            }
                            else if (listaClientes.Last() == usuario)
                            {
                                Cliente cliente = new Cliente(txtboxNombreUsuario.Text, txtboxContraseñaUsuario.Text, txtboxMailUsuario.Text);
                                listaClientes.Add(cliente);
                                lstboxUsuarios.Items.Add(cliente.Datos2());
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo de Email deve de tener un correo electrónico: @gmail.com,@hotmail.com o @outlook.com");
                }
            }
            else
            {
                if (txtboxNombreUsuario.Text.Trim() == "")
                {
                    txtboxNombreUsuario.Clear();
                }
                if (txtboxContraseñaUsuario.Text.Trim() == "")
                {
                    txtboxContraseñaUsuario.Clear();
                }
                if (txtboxMailUsuario.Text.Trim() == "")
                {
                    txtboxMailUsuario.Clear();
                }
                MessageBox.Show("No debe dejar ninún espacio en blanco");
            }
        }
        public void RemoveClient(ListBox lstboxUsuarios)
        {
            if (lstboxUsuarios.SelectedIndex != -1)
            {
                lstboxUsuarios.Items.Remove(lstboxUsuarios.SelectedItem);
                listaClientes.RemoveAt(lstboxUsuarios.SelectedIndex + 1);
            }
        }
    }
}
