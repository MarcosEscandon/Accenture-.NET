namespace Marcos_Escandon_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1 = txtConvert.Text;
            int numero1 = Convert.ToInt32(string1);
            MessageBox.Show("Valor original string: " + string1 + " valor Convert int: " + numero1);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string string2 = txtParse.Text;
            int numero2 = int.Parse(string2);
            MessageBox.Show("Valor original string: " + string2 + " valor Convert int: " + numero2);
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            string string3 = txtTryParse.Text;
            bool seConvirtio = int.TryParse(string3, out int numero3);
            if (seConvirtio)
            {
                MessageBox.Show("Valor original string: " + string3 + " valor Convert int: " + numero3);
            }
            else
            {
                MessageBox.Show("No se pudo convertir " + string3);
            }
        }
    }
}