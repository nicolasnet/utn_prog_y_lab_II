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

       

        

        private void textEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            double numero = 0;
            Euro monedaEuro = new Euro(0);
            Dolar monedaDolar = new Dolar(0);
            Pesos monedaPesos = new Pesos(0);            

            if(double.TryParse(textEuro.Text, out numero))
            {                
                txtEuroAEuro.Text = numero.ToString();

                monedaEuro = numero;
                
                monedaDolar = (Dolar)monedaEuro;
                txtEuroADolar.Text = monedaDolar.GetCantidad().ToString();

                monedaPesos = (Pesos)monedaEuro;
                txtEuroAPesos.Text = monedaPesos.GetCantidad().ToString();
            }            
        }

        private void btnConverDolar_Click(object sender, EventArgs e)
        {
            double numero = 0;
            Euro monedaEuro = new Euro(0);
            Dolar monedaDolar = new Dolar(0);
            Pesos monedaPesos = new Pesos(0);

            if (double.TryParse(textDolar.Text, out numero))
            {
                monedaDolar = numero;

                monedaEuro = (Euro)monedaDolar;
                txtDolarAEuro.Text = monedaEuro.GetCantidad().ToString();

                txtDolarADolar.Text = numero.ToString();

                monedaPesos = (Pesos)monedaDolar;
                txtDolarAPesos.Text = monedaPesos.GetCantidad().ToString();
            }
        }

        private void btnConverPesos_Click(object sender, EventArgs e)
        {
            double numero = 0;
            Euro monedaEuro = new Euro(0);
            Dolar monedaDolar = new Dolar(0);
            Pesos monedaPesos = new Pesos(0);

            if (double.TryParse(textDolar.Text, out numero))
            {
                monedaPesos = numero;

                monedaEuro = (Euro)monedaPesos;
                txtPesosAEuro.Text = monedaEuro.GetCantidad().ToString();

                monedaDolar = (Dolar)monedaPesos;
                txtPesosADolar.Text = monedaDolar.GetCantidad().ToString();

                txtPesosAPesos.Text = numero.ToString();
            }

        }

    }
}
