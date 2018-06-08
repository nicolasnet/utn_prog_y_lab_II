using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto("Jorge", 27f);

            ProductoDAO.Guardar(prod);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Producto prod = null;

            prod = ProductoDAO.Leer();

            richTextBox1.Text = string.Format("Name: {0}\nCostRate: {1}", prod.Nombre, prod.CostRate);
        }
    }
}
