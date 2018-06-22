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

namespace Gomez.Nicolas._2C
{
    public partial class Form1 : Form
    {
        private LosHilos hilos;

        public Form1()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.AvisoFin += MostrarMensajeFin;
        }



        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
            //hilos.Bitacora = "Hola probando";
        }               


        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.hilos += 1;
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
