using Models.ModelDerivada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsTransporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tripulacion tripulacion;
        private void btnMostrarHelicoptero_Click(object sender, EventArgs e)
        {
            Helicoptero helicoptero = new Helicoptero(4, 3, 160, 15000);
            MessageBox.Show(helicoptero.Mostrar());
            MessageBox.Show(helicoptero.Despegar(false));
            MessageBox.Show(helicoptero.Aterrizar(false));
        }

        private void btnMostrarJet_Click(object sender, EventArgs e)
        {

            Piloto piloto = new Piloto("Juan", "Perez");
            Copiloto copiloto = new Copiloto("Martin", "Gonzalez");
            List<Azafata> azafatas = new List<Azafata>();
            Azafata azafata = new Azafata() { Apellido = "Garcia", Nombre = "Maria" };

            tripulacion = new Tripulacion(piloto, copiloto, azafatas);
            tripulacion.AgregarAzafata(azafata);
            MessageBox.Show($"Azafata {azafata.Nombre} agregada con éxito");
            Jet jet = new Jet(tripulacion, 5, 20000, 100);
            MessageBox.Show(jet.Mostrar());
            MessageBox.Show(jet.Despegar(true));
            MessageBox.Show(jet.Aterrizar(true));
            MessageBox.Show(jet.Informar());

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            tripulacion.EliminarAzafata();
            MessageBox.Show("Azafatas dadas de baja por mantenimiento");
        }
    }
}
