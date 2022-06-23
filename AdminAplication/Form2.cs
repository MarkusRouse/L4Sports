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
        List<Cliente> listaClientes = new List<Cliente>();
        List<User> listaAdmins = new List<User>();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((txtboxContraseñaUsuario.Text).Trim() != "" && (txtboxNombreUsuario.Text).Trim() != "" && (txtboxMailUsuario.Text).Trim() != "")
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
                        if (usuario.Nombre == txtboxNombreUsuario.Text || usuario.Mail == txtboxMailUsuario.Text)
                        {
                            MessageBox.Show("El usuario ya existe, por favor ingrese uno con otras características");
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
            if (lstboxUsuarios.SelectedIndex != -1)
            {
                lstboxUsuarios.Items.Remove(lstboxUsuarios.SelectedItem);
                listaClientes.RemoveAt(lstboxUsuarios.SelectedIndex + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAdmUsuario.Show();
            pnlAdmAdministradores.Hide();
            /*
            pnlAdmUsuario.Visible = true;
            pnlAdmAdministradores.Visible = false;
            */
        }

        private void pnlAdmInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdmUsuario.Hide();
            pnlAdmAdministradores.Show();
            /*
            pnlAdmUsuario.Visible = false;
            pnlAdmAdministradores.Visible = true;
            */
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cerrando sesión");
            Form1 ventanaLogin = new Form1();
            this.Hide();
            ventanaLogin.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirAdministrador_Click(object sender, EventArgs e)
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

        private void btnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            if (lstboxAdministradores.SelectedIndex != -1)
            {
                lstboxAdministradores.Items.Remove(lstboxAdministradores.SelectedItem);
                listaAdmins.RemoveAt(lstboxAdministradores.SelectedIndex + 1);
            }
        }
    }

    public class User
    {
        string nombre, contraseña;

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

        public User()
        {

        }
        public User(string nombre,string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        public string Datos1()
        {
            return (nombre + " " + contraseña);
        }
    }
    public class Cliente : User
    {
        string mail;

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
        public Cliente()
        {

        }
        public Cliente(string _nombre,string _contraseña,string _mail)
        {
            Nombre = _nombre;
            Contraseña = _contraseña;
            mail = _mail;
        }
        public string Datos2()
        {
            return (Nombre + " " + Contraseña + " " + mail);
        }
    }

}
