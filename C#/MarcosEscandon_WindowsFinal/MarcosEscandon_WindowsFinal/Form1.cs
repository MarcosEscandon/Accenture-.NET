using Microsoft.VisualBasic;

namespace MarcosEscandon_WindowsFinal
{
    public partial class Form1 : Form
    {

        double[] horas;
        string[] dias;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
  
        private void CargarHoras(string[] dias, double[] horas)
        {
            for (int i = 0; i < horas.Length; i++)
            {
                horas[i] = Convert.ToDouble(Interaction.InputBox($"Ingrese las horas del {dias[i]}:"));
            }
        }

        private double SumarHoras(double[] horas)
        {
            double suma = 0;
            for (int i = 0; i < horas.Length; i++)
            {
                suma = suma + horas[i];
            }
            return suma;
        }

        private double PromedioHoras(double[] horas)
        {
            return SumarHoras(horas) / 5;
        }

        private void Mas4(double[] horas, string[] dias)
        {

            for (int i = 0; i < horas.Length; i++)
            {
                if (horas[i] < 4)
                {
                    MessageBox.Show($"El {dias[i]} trabajaste menos de 4hrs");
                }
            }
        }

        private void btnValidaciones_Click_1(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            string puesto = txtPuesto.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (sueldo > 0)
            {
                if (puesto.ToUpper() == "SOPORTE TECNICO" || puesto.ToUpper() == "DBA" || puesto.ToUpper() == "DESARROLLADOR")
                {
                    if (nombre.Length > 2 && nombre.Length < 50 && apellido.Length > 2 && apellido.Length < 50)
                    {
                        MessageBox.Show("Data validada");
                    }
                    else
                    {
                        MessageBox.Show("Nombre y apellido debe ser mayor de 2 caracteres y menor que 50");
                    }

                }
                else
                {
                    MessageBox.Show("El puesto ingresado no existe");
                }
            }
            else
            {
                MessageBox.Show("El sueldo debe ser mayor a 0");
            }
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = txtPuesto.Text;
            MessageBox.Show($"{nombre.ToUpper()} {apellido.ToUpper()} {puesto.ToUpper()}");
        }

        private void btnIngresarHoras_Click_1(object sender, EventArgs e)
        {
            horas = new double[5];
            dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            CargarHoras(dias, horas);
            MessageBox.Show($"Trabajaste {SumarHoras(horas)}hrs en la semana\nUn promedio de{PromedioHoras(horas)}hrs");
            Mas4(horas, dias);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtPuesto.Clear();
            txtSueldo.Clear();
        }
    }
}