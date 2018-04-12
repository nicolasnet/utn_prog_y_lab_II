using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06;

namespace Clase06
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            double numero = 0;
            Euro monedaEuro = new Euro(0);
            Dolar monedaDolar = new Dolar(0);
            //StringBuilder texto = new StringBuilder();

            if(double.TryParse(textEuro.Text, out numero))
            {                
                txtEuroAEuro.Text = numero.ToString();

            }            
        }

    }
}
