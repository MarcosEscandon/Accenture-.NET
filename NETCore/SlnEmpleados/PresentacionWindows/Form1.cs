using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento(5, "Sistemas");
            Empleado empleado1 = new Empleado("Jhon", "Doe", 1, 3601);
            empleado1.Departamento = departamento;
            Empleado empleado2 = new Empleado("Mark", "Zuck", 2, 3602);
            empleado2.Departamento = departamento;
            Empleado empleado3 = new Empleado("Robert", "Patt", 3, 3603);
            empleado3.Departamento = departamento;
            List<Empleado> lista = new List<Empleado>();
            lista.Add(empleado1);
            lista.Add(empleado2);
            lista.Add(empleado3);
            departamento.Empleados = lista;
            gridEmpleados.DataSource = departamento.Empleados;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
