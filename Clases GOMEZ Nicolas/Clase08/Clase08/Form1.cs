﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, flag = 0;
            Dictionary<string, int> diccionario = new Dictionary<string,int>();
            int inicio = 0;
            int final;
            string palabra = "";
            

            for (i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ' ' || i == textBox1.Text.Length - 1)
                {
                    final = i;

                    palabra = textBox1.Text.Substring(inicio, final + 1 - inicio);
                    palabra = palabra.Trim(); //saca los espacios en blanco.
                    
                    foreach (KeyValuePair<string, int> entrada in diccionario)
                    {
                        flag = 0;
                        if((palabra == entrada.Key))
                        {
                            //diccionario.ContainsKey() ahorra el foreach
                            diccionario[entrada.Key]++;                            
                            flag = 1;
                            break;
                        }                        
                    }
                    if (flag == 0)
                    {
                        diccionario.Add(palabra, 1);
                    }

                    inicio = i + 1;
                }                
            }

             foreach (KeyValuePair<string, int> entrada in diccionario)
            {
                MessageBox.Show(entrada.Key, entrada.Value.ToString());                
            }
        }
    }
}
