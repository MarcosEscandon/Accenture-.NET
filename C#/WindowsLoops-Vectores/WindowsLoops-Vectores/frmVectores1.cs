using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLoops_Vectores
{
    public partial class frmVectores1 : Form
    {
        string[] alumnos;
        double[] notas1;
        double[] notas2;
        double[] notas3;
        double[] notas4;
        double[] promedios;
        double[] notaMax;
        public frmVectores1()
        {
            InitializeComponent();
        }

        private void CargarNotas(double[] notas, string[] alumnos)
        {

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToDouble(Interaction.InputBox($"Ingresar la Nota {i + 1}:"));
            }

        }

        private void CargarNombres(string[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = Interaction.InputBox($"Ingresar el nombre del alumno {i + 1}: ");
            }
        }

        private double MayorNota(double[] notas)
        {
            double mayor = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (mayor < notas[i]) mayor = notas[i];
            }
            return mayor;
        }

        private double CalcularPromedio(double[] notas)
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            return suma / notas.Length;
        }

        private void Mostrar(string[] alumnos, double[] notaMax, double[] promedios)
        {
            double promedio1 = CalcularPromedio(notas1);
            double promedio2 = CalcularPromedio(notas2);
            double promedio3 = CalcularPromedio(notas3);
            double promedio4 = CalcularPromedio(notas4);
            double notamax1 = MayorNota(notas1);
            double notamax2 = MayorNota(notas2);
            double notamax3 = MayorNota(notas3);
            double notamax4 = MayorNota(notas4);

            promedios = new double[] { promedio1, promedio2, promedio3, promedio4 };
            notaMax = new double[] { notamax1, notamax2, notamax3, notamax4 };

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (promedios[i] < 4)
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedios[i]}\nMayor nota: {notaMax[i]}\nVas a recuperatorio");
                }
                else if (promedios[i] >= 4 && promedios[i] <= 7)
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedios[i]}\nMayor nota: {notaMax[i]}\nBien");
                }
                else
                {
                    MessageBox.Show($"Promedio de {alumnos[i]}: {promedios[i]}\nMayor nota: {notaMax[i]}\nMuy bien");
                }
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            alumnos = new string[4];
            notas1 = new double[3];
            notas2 = new double[3];
            notas3 = new double[3];
            notas4 = new double[3];

            CargarNombres(alumnos);
            CargarNotas(notas1, alumnos);
            CargarNotas(notas2, alumnos);
            CargarNotas(notas3, alumnos);
            CargarNotas(notas4, alumnos);
            Mostrar(alumnos, promedios, notaMax);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
