using System;
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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlAdmAdministradores_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void CreateUser(string nombre, string contraseña)
        {
            User user1 = new User(nombre, contraseña);
            listaUsuarios.Add(user1);
        }
       
    }
    public class ListaDeUsuarios
    {
        List<User> listaUsuarios = new List<User>();
        public List<User> GetLista
        {
            get
            {
                return listaUsuarios;
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
    }

}
