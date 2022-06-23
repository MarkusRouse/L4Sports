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
                    if (usuario.Nombre == txtboxNombreUsuario.Text)
                    {
                        if (usuario.Contraseña == txtboxContraseñaUsuario.Text)
                        {
                            if (usuario.Mail == txtboxMailUsuario.Text)
                            {
                                MessageBox.Show("El usuario ya existe, por favor ingrese uno con otras características");
                                break;
                            }
                            else
                            {
                                Cliente cliente = new Cliente(txtboxNombreUsuario.Text, txtboxContraseñaUsuario.Text, txtboxMailUsuario.Text);
                                listaClientes.Add(cliente);
                                lstboxUsuarios.Items.Add(cliente.Datos2());
                                break;
                            }
                        }
                    }
                }
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
            lstboxUsuarios.Items.Remove(lstboxUsuarios.SelectedItem);
            listaClientes.RemoveAt(lstboxUsuarios.SelectedIndex + 1);
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
        public string datos1()
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
