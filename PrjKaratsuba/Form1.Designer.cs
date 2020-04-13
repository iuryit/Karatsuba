namespace PrjKaratsuba
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQteDigitos_1 = new System.Windows.Forms.TextBox();
            this.txtNum1_1 = new System.Windows.Forms.TextBox();
            this.txtNum2_1 = new System.Windows.Forms.TextBox();
            this.txtResposta_1 = new System.Windows.Forms.TextBox();
            this.BtnCalcularAle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCaulcularDig = new System.Windows.Forms.Button();
            this.txtResultado_2 = new System.Windows.Forms.TextBox();
            this.txtNum2_2 = new System.Windows.Forms.TextBox();
            this.txtNum1_2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCalcularAle);
            this.panel1.Controls.Add(this.txtResposta_1);
            this.panel1.Controls.Add(this.txtNum2_1);
            this.panel1.Controls.Add(this.txtNum1_1);
            this.panel1.Controls.Add(this.txtQteDigitos_1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 141);
            this.panel1.TabIndex = 1;
            // 
            // txtQteDigitos_1
            // 
            this.txtQteDigitos_1.Location = new System.Drawing.Point(22, 63);
            this.txtQteDigitos_1.Name = "txtQteDigitos_1";
            this.txtQteDigitos_1.Size = new System.Drawing.Size(100, 20);
            this.txtQteDigitos_1.TabIndex = 1;
            // 
            // txtNum1_1
            // 
            this.txtNum1_1.Location = new System.Drawing.Point(387, 32);
            this.txtNum1_1.Name = "txtNum1_1";
            this.txtNum1_1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1_1.TabIndex = 2;
            // 
            // txtNum2_1
            // 
            this.txtNum2_1.Location = new System.Drawing.Point(387, 93);
            this.txtNum2_1.Name = "txtNum2_1";
            this.txtNum2_1.Size = new System.Drawing.Size(100, 20);
            this.txtNum2_1.TabIndex = 3;
            // 
            // txtResposta_1
            // 
            this.txtResposta_1.Location = new System.Drawing.Point(578, 63);
            this.txtResposta_1.Name = "txtResposta_1";
            this.txtResposta_1.Size = new System.Drawing.Size(169, 20);
            this.txtResposta_1.TabIndex = 4;
            // 
            // BtnCalcularAle
            // 
            this.BtnCalcularAle.Location = new System.Drawing.Point(180, 32);
            this.BtnCalcularAle.Name = "BtnCalcularAle";
            this.BtnCalcularAle.Size = new System.Drawing.Size(102, 81);
            this.BtnCalcularAle.TabIndex = 5;
            this.BtnCalcularAle.Text = "Calcular";
            this.BtnCalcularAle.UseVisualStyleBackColor = true;
            this.BtnCalcularAle.Click += new System.EventHandler(this.buttonCalcularAle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade de digitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1º Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2º Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BtnCaulcularDig);
            this.panel2.Controls.Add(this.txtResultado_2);
            this.panel2.Controls.Add(this.txtNum2_2);
            this.panel2.Controls.Add(this.txtNum1_2);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 141);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "2º Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "1º Numero";
            // 
            // BtnCaulcularDig
            // 
            this.BtnCaulcularDig.Location = new System.Drawing.Point(180, 33);
            this.BtnCaulcularDig.Name = "BtnCaulcularDig";
            this.BtnCaulcularDig.Size = new System.Drawing.Size(102, 81);
            this.BtnCaulcularDig.TabIndex = 5;
            this.BtnCaulcularDig.Text = "Calcular";
            this.BtnCaulcularDig.UseVisualStyleBackColor = true;
            this.BtnCaulcularDig.Click += new System.EventHandler(this.BtnCaulcularDig_Click);
            // 
            // txtResultado_2
            // 
            this.txtResultado_2.Location = new System.Drawing.Point(578, 63);
            this.txtResultado_2.Name = "txtResultado_2";
            this.txtResultado_2.Size = new System.Drawing.Size(169, 20);
            this.txtResultado_2.TabIndex = 4;
            // 
            // txtNum2_2
            // 
            this.txtNum2_2.Location = new System.Drawing.Point(22, 94);
            this.txtNum2_2.Name = "txtNum2_2";
            this.txtNum2_2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2_2.TabIndex = 3;
            // 
            // txtNum1_2
            // 
            this.txtNum1_2.Location = new System.Drawing.Point(22, 35);
            this.txtNum1_2.Name = "txtNum1_2";
            this.txtNum1_2.Size = new System.Drawing.Size(100, 20);
            this.txtNum1_2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalcularAle;
        private System.Windows.Forms.TextBox txtResposta_1;
        private System.Windows.Forms.TextBox txtNum2_1;
        private System.Windows.Forms.TextBox txtNum1_1;
        private System.Windows.Forms.TextBox txtQteDigitos_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCaulcularDig;
        private System.Windows.Forms.TextBox txtResultado_2;
        private System.Windows.Forms.TextBox txtNum2_2;
        private System.Windows.Forms.TextBox txtNum1_2;
    }
}

