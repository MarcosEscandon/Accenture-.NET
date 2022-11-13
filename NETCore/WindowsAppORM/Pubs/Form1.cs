using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace Pubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Creamos la instancia
            Publisher publisher = new Publisher() { Pub_id = "7600", City = "Mar del Plata", Country = "Argentina", Pub_name = "MDQ", State = "BA" };

            //DBset
            context.Publishers.Add(publisher);
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = "5005";
            Publisher publisherDB = context.Publishers.Find(id);

            if (publisherDB != null)
            {
                publisherDB.Country = "Argentina";
                publisherDB.City = "Buenos Aires";

            }
            else
            {
                MessageBox.Show("No existe registro con esa id");
            }
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Publisher publisherDB = context.Publishers.Find(id);

            if (publisherDB != null)
            {
                context.Publishers.Remove(publisherDB);
            }
            else
            {
                MessageBox.Show("No existe registro con esa id");
            }
            //Guardar en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK Eliminado");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Publisher> list = context.Publishers.ToList();
            gridPublishers.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
