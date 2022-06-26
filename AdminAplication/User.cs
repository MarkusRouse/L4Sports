using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAplication
{
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
        public User(string nombre, string contraseña)
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
        public Cliente(string _nombre, string _contraseña, string _mail)
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
