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
    public partial class Form3 : Form
    {
        Llamada.TipoLlamada llamadaTipo;
        Centralita central;

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.llamadaTipo = value;
            }
        }




        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
