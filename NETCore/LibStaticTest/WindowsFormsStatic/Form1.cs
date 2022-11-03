using LibStaticTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(25, "Jose", "Perez");
            MessageBox.Show($"{Empleado.Comision.ToString()}");

            Empleado empleado2 = new Empleado(28, "Martin", "Gomez");
            Empleado.Comision = 5002;
            MessageBox.Show($"{Empleado.Comision.ToString()}");

            Empleado empleado3 = new Empleado(25, "Jose", "Perez");
            MessageBox.Show($"{Empleado.Comision.ToString()}");
            Empleado.Comision = 6000;
            MessageBox.Show($"{Empleado.Comision.ToString()}");

        }
    }
}
