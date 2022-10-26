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
    public partial class frmVectores4 : Form
    {
        string[] nombres;
        int[] edades;
        public frmVectores4()
        {
            InitializeComponent();
        }
        private void CargarDatos(string[] nombres, int[] edades)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingresa el nombre:");
                edades[i] = Convert.ToInt32(Interaction.InputBox("Ingresa la edad:"));
            }
        }

        private void Mayores(int[] edades, string[] nombres)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    MessageBox.Show($"{nombres[i]} es mayor de edad");
                }
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            nombres = new string[5];
            edades = new int[5];

            CargarDatos(nombres, edades);
            Mayores(edades, nombres);
        }
    }
}
