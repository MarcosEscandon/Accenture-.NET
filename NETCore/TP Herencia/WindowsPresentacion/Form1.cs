using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            Terrestre auto = new Terrestre("Audi", "Azul", "Nafta", 6, 4, "Particular");

            MessageBox.Show("Objeto creado\n\nMarca: " + auto.Marca + "\nColor: " + auto.Color + "\nCombustible: " + auto.Combustible + "\nCantidad de cilindros: " + auto.CantidadCilindros + "\nCantidad de ruedas: " + auto.Ruedas + "\nUtilidad: " + auto.Utilidad);
            
            Aereo avion = new Aereo("Boeing", "Blanco", "Combustible de avión", 0, 2, 10000);

            MessageBox.Show("Objeto creado\n\nMarca: " + avion.Marca + "\nColor: " + avion.Color + "\nCombustible: " + avion.Combustible + "\nCantidad de cilindros: " + avion.CantidadCilindros + "\nCantidad de motores: " + avion.Motores + "\nAltura máxima: " + avion.AlturaMaxima + " metros");
        }
    }
}
