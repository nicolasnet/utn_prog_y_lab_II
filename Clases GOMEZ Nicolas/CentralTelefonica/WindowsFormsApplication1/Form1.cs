using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaAbstracta;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarLLamada_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
 
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.TipoLlamada = Llamada.TipoLlamada.Todas;
            
            form.ShowDialog();
            
        }
    }
}
