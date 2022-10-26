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
    public partial class frmVectores5 : Form
    {
        string[] provincias;
        double[] temp1;
        double[] temp2;
        double[] temp3;
        double[] temp4;
        double[] trimestral;
        public frmVectores5()
        {
            InitializeComponent();
        }
        private void CargarTemp(string[] provincias, double[] temp)
        {
            for (int j = 0; j < temp.Length; j++)
            {
                temp[j] = Convert.ToDouble(Interaction.InputBox($"Ingresar la temperatura {j + 1}"));
            }
        }

        private void CargarProvincias(string[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i] = Interaction.InputBox($"Ingresar la provincia {i + 1}: ");
            }
        }

        private double Promedio(double[] temp)
        {
            double suma = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                suma = suma + temp[i];
            }
            return suma / temp.Length;
        }

        private void Mostrar(string[] provincias)
        {
            double trim1 = Promedio(temp1);
            double trim2 = Promedio(temp2);
            double trim3 = Promedio(temp3);
            double trim4 = Promedio(temp4);

            trimestral = new double[] { trim1, trim2, trim3, trim4 };

            for (int i = 0; i < provincias.Length; i++)
            {
                MessageBox.Show($"{provincias[i]}\nTemperatura media:{trimestral[i]}");
            }

            MessageBox.Show($"La provincia con mayor temperatura media trimestral es {MaxTemp(provincias, trimestral)}");
        }

        private string MaxTemp(string[] provincias, double[] trimestral)
        {
            string prov = "";
            double max = 0;
            for (int i = 0; i < trimestral.Length; i++)
            {
                if (max < trimestral[i])
                {
                    max = trimestral[i];
                    prov = provincias[i];
                }
            }
            return prov;
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            provincias = new string[4];
            temp1 = new double[3];
            temp2 = new double[3];
            temp3 = new double[3];
            temp4 = new double[3];
            trimestral = new double[4];

            CargarProvincias(provincias);
            CargarTemp(provincias, temp1);
            CargarTemp(provincias, temp2);
            CargarTemp(provincias, temp3);
            CargarTemp(provincias, temp4);

            Mostrar(provincias);
        }
    }
}
