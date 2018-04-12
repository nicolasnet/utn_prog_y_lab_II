namespace Clase06
{
    partial class Conversor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConverPesos = new System.Windows.Forms.Button();
            this.btnConverEuro = new System.Windows.Forms.Button();
            this.btnConverDolar = new System.Windows.Forms.Button();
            this.textEuro = new System.Windows.Forms.TextBox();
            this.textPesos = new System.Windows.Forms.TextBox();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConverPesos
            // 
            this.btnConverPesos.Location = new System.Drawing.Point(233, 140);
            this.btnConverPesos.Name = "btnConverPesos";
            this.btnConverPesos.Size = new System.Drawing.Size(95, 20);
            this.btnConverPesos.TabIndex = 0;
            this.btnConverPesos.Text = "->";
            this.btnConverPesos.UseVisualStyleBackColor = true;
            // 
            // btnConverEuro
            // 
            this.btnConverEuro.Location = new System.Drawing.Point(233, 65);
            this.btnConverEuro.Name = "btnConverEuro";
            this.btnConverEuro.Size = new System.Drawing.Size(95, 20);
            this.btnConverEuro.TabIndex = 1;
            this.btnConverEuro.Text = "->";
            this.btnConverEuro.UseVisualStyleBackColor = true;
            this.btnConverEuro.Click += new System.EventHandler(this.btnConverEuro_Click);
            // 
            // btnConverDolar
            // 
            this.btnConverDolar.Location = new System.Drawing.Point(233, 104);
            this.btnConverDolar.Name = "btnConverDolar";
            this.btnConverDolar.Size = new System.Drawing.Size(95, 20);
            this.btnConverDolar.TabIndex = 2;
            this.btnConverDolar.Text = "->";
            this.btnConverDolar.UseVisualStyleBackColor = true;
            // 
            // textEuro
            // 
            this.textEuro.Location = new System.Drawing.Point(110, 65);
            this.textEuro.Name = "textEuro";
            this.textEuro.Size = new System.Drawing.Size(117, 20);
            this.textEuro.TabIndex = 4;
            this.textEuro.TextChanged += new System.EventHandler(this.textEuro_TextChanged);
            // 
            // textPesos
            // 
            this.textPesos.Location = new System.Drawing.Point(110, 140);
            this.textPesos.Name = "textPesos";
            this.textPesos.Size = new System.Drawing.Size(117, 20);
            this.textPesos.TabIndex = 5;
            // 
            // textDolar
            // 
            this.textDolar.Location = new System.Drawing.Point(110, 104);
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(117, 20);
            this.textDolar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dólar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dólar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Euro";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(334, 65);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(95, 20);
            this.txtEuroAEuro.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(435, 65);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(95, 20);
            this.txtEuroADolar.TabIndex = 14;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Enabled = false;
            this.txtEuroAPesos.Location = new System.Drawing.Point(536, 65);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(95, 20);
            this.txtEuroAPesos.TabIndex = 15;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Enabled = false;
            this.txtPesosAPesos.Location = new System.Drawing.Point(536, 140);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(95, 20);
            this.txtPesosAPesos.TabIndex = 18;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Enabled = false;
            this.txtPesosADolar.Location = new System.Drawing.Point(435, 140);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(95, 20);
            this.txtPesosADolar.TabIndex = 17;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Enabled = false;
            this.txtPesosAEuro.Location = new System.Drawing.Point(334, 140);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(95, 20);
            this.txtPesosAEuro.TabIndex = 16;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Enabled = false;
            this.txtDolarAPesos.Location = new System.Drawing.Point(536, 104);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(95, 20);
            this.txtDolarAPesos.TabIndex = 21;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(435, 104);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(95, 20);
            this.txtDolarADolar.TabIndex = 20;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(334, 104);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(95, 20);
            this.txtDolarAEuro.TabIndex = 19;
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 172);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.textPesos);
            this.Controls.Add(this.textEuro);
            this.Controls.Add(this.btnConverDolar);
            this.Controls.Add(this.btnConverEuro);
            this.Controls.Add(this.btnConverPesos);
            this.Name = "Conversor";
            this.Text = "Conversor";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverPesos;
        private System.Windows.Forms.Button btnConverEuro;
        private System.Windows.Forms.Button btnConverDolar;
        private System.Windows.Forms.TextBox textEuro;
        private System.Windows.Forms.TextBox textPesos;
        private System.Windows.Forms.TextBox textDolar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
    }
}