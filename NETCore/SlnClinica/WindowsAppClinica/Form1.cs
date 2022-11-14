using Entidades.EntidadesDerivadas.Pediatria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPediatra_Click(object sender, EventArgs e)
        {
            MedicoPediatra pediatra1 = new MedicoPediatra(1, "MP5462", "Juan", "Caseros", "32467231", new DateTime(1982 / 12 / 13));
            MessageBox.Show("Pediatra: " + "\nNombre: " + pediatra1.Nombre + "\nApellido: " + pediatra1.Apellido);
        }
    }
}
