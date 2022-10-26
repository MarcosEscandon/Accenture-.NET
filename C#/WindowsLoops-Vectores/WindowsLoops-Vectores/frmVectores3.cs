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
    public partial class frmVectores3 : Form
    {
        string[] Operarios;
        double[] Sueldos1;
        double[] Sueldos2;
        double[] Sueldos3;
        double[] Sueldos4;
        double[] Suma;
        public frmVectores3()
        {
            InitializeComponent();
        }
        private void CargarNombres(string[] Operarios)
        {
            for (int i = 0; i < Operarios.Length; i++)
            {
                Operarios[i] = Interaction.InputBox($"Ingresar el nombre del Operario {i + 1}: ");
            }
        }

        private void CargarSueldos(double[] Sueldos)
        {

            for (int i = 0; i < Sueldos.Length; i++)
            {
                Sueldos[i] = Convert.ToDouble(Interaction.InputBox($"Ingresar el sueldo {i + 1}:"));
            }

        }

        private double SueldoAcumulado(double[] Sueldos)
        {
            double total = 0;
            for (int i = 0; i < Sueldos.Length; i++)
            {
                total = total + Sueldos[i];
            }
            return total;
        }

        private void Mostrar(double[] Suma, string[] Operarios)
        {
            double Acumulado1 = SueldoAcumulado(Sueldos1);
            double Acumulado2 = SueldoAcumulado(Sueldos2);
            double Acumulado3 = SueldoAcumulado(Sueldos3);
            double Acumulado4 = SueldoAcumulado(Sueldos4);
            Suma = new double[] { Acumulado1, Acumulado2, Acumulado3, Acumulado4 };
            double MayorSueldo = 0;
            int index = 0;

            for (int i = 0; i < Suma.Length; i++)
            {
                MessageBox.Show($"El sueldo total del operario {i + 1} es ${Suma[i]}");

                if (MayorSueldo < Suma[i])
                {
                    MayorSueldo = Suma[i];
                    index = i;
                }
            }

            MessageBox.Show($"El Operario que gano mas en los ultimos 3 meses fue {Operarios[index]}");

        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            Operarios = new string[4];
            Sueldos1 = new double[3];
            Sueldos2 = new double[3];
            Sueldos3 = new double[3];
            Sueldos4 = new double[3];


            CargarNombres(Operarios);
            CargarSueldos(Sueldos1);
            CargarSueldos(Sueldos2);
            CargarSueldos(Sueldos3);
            CargarSueldos(Sueldos4);
            Mostrar(Suma, Operarios);
        }
    }
}
