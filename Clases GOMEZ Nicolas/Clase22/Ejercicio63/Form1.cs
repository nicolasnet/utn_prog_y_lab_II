using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ClassLibrary1.Ejerc63;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        //private Thread tiempo;
        private Temporizador temp;

        public Form1()
        {
            InitializeComponent();
            temp = new Temporizador(1000, true);
            temp.EventoTiempo += this.AsignarHora;

            //tiempo = new Thread(AsignarHora);
            //tiempo.Start();
            //timer1.Start();
        }


        //public void AsignarHora()
        //{
        //    while (true)
        //    {
        //        lblHora.Text = DateTime.Now.ToString();
        //        Thread.Sleep(100);
        //    }
        //}

        //
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    AsignarHora();
        //}
        //


        /*
        public void AsignarHora()
        {            
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }
        }
        */


        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                encargadoTiempo aux = new encargadoTiempo(AsignarHora);
                this.Invoke(aux);

            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            temp.Activo = false;
        }


        /*
        public void AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString();
        }

        */



               

        /*
        private void timer1_Tick(object sender, EventArgs e)
        {            
            AsignarHora();
            
            //timer1.Stop();
        }
        */       

    }
}
