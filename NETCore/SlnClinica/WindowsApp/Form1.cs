using LibSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            AdminSeguridad admin1 = new AdminSeguridad(usuario, contrasena);

            bool validacion = admin1.LoginUser(usuario, contrasena);
           
            if(validacion == true)
            {
                MessageBox.Show("USUARIO VALIDADO CON EXITO");
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASENA ERRONEOS, INTENTE NUEVAMENTE");
            }
        }
    }
}
