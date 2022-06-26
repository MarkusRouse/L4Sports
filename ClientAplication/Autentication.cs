using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAplication
{
    public class Autentication
    {
        private List<User> listaUsuarios = new List<User>();
        public void CrearUsuarios()
        {
            CreateUser("user", "user", "correo@gmail.com");
            CreateUser("user1", "user1", "correo1@gmail.com");
            CreateUser("user2", "user2", "correo2@gmail.com");
        }
        public void CreateUser(string nombre, string contraseña, string email)
        {
            User user1 = new User(nombre, contraseña, email);
            listaUsuarios.Add(user1);
        }
        public void Login(string nombreUsuario, string contraseñaUsuario, Form1 frm1, Form2 frm2)
        {
            if ((nombreUsuario.Trim() != "" && contraseñaUsuario.Trim() != ""))
            {
                for (int i = 0; i < listaUsuarios.Count(); i++)
                {
                    if ((nombreUsuario == listaUsuarios[i].Nombre || nombreUsuario == listaUsuarios[i].Mail) && contraseñaUsuario == listaUsuarios[i].Contraseña)
                    {
                        MessageBox.Show("Bienvenido");
                        frm1.Hide();
                        frm2.Show();
                        break;
                    }
                    else if (i + 1 == listaUsuarios.Count())
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, no debe dejar ningún espacio en blanco");
            }
        }
    }
    public class User
    {
        string nombre, contraseña, mail;

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

        public User()
        {

        }
        public User(string nombre, string contraseña, string mail)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.mail = mail;
        }
    }
}
