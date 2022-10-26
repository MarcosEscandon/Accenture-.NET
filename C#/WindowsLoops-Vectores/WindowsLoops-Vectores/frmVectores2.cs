using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLoops_Vectores
{
    public partial class frmVectores2 : Form
    {
        double[] precios;
        public frmVectores2()
        {
            InitializeComponent();
        }
        private void CargarPrecios(double[] precios)
        {
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i] = Convert.ToDouble(Interaction.InputBox($"Ingrese el precio {i + 1}:"));
            }
        }

        private double CalcularTotal(double[] precios)
        {
            double total = 0;
            for (int i = 0; i < precios.Length; i++)
            {
                total = total + precios[i];
            }
            return total;
        }

        private void btnSumar_Click_1(object sender, EventArgs e)
        {
            precios = new double[8];
            CargarPrecios(precios);
            MessageBox.Show($"Su total es ${CalcularTotal(precios)}");
        }
    }
}
