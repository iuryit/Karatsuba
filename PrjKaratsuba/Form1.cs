using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjKaratsuba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcularAle_Click(object sender, EventArgs e)
        {            
            double i = Math.Pow(10, (int.Parse(txtQteDigitos_1.Text) - 1));
            double j = Math.Pow(10, (int.Parse(txtQteDigitos_1.Text)));
            j = j - 1;
            Random random = new Random();
            txtNum1_1.Text = random.Next((int)Math.Pow(10, (int.Parse(txtQteDigitos_1.Text) - 1)), (int)Math.Pow(10, (int.Parse(txtQteDigitos_1.Text)))).ToString();
            txtNum2_1.Text = random.Next((int)Math.Pow(10, (int.Parse(txtQteDigitos_1.Text) - 1)), (int)Math.Pow(10, (int.Parse(txtQteDigitos_1.Text)))).ToString();

            int tam = txtNum1_1.Text.Length;
            double a = tam;
            if (tam % 2 != 0)
            {
                txtNum1_1.Text = "0" + txtNum1_1.Text;
                tam = txtNum1_1.Text.Length;
                a = tam;
            }
            string primeirametade1, segundametade1, primeirametade2, segundametade2;
            primeirametade1 = txtNum1_1.Text.Substring(0, (tam / 2));
            segundametade1 = txtNum1_1.Text.Substring((tam / 2), (tam / 2));
            tam = txtNum2_1.Text.Length;
            if (tam % 2 != 0)
            {
                txtNum2_1.Text = "0" + txtNum2_1.Text;
                tam = txtNum2_1.Text.Length;
            }
            primeirametade2 = txtNum2_1.Text.Substring(0, (tam / 2));
            segundametade2 = txtNum2_1.Text.Substring((tam / 2), (tam / 2));
            int primeiro = (int.Parse(primeirametade1) * int.Parse(primeirametade2));
            int segundo = (int.Parse(segundametade1) * int.Parse(segundametade2));
            int y = primeiro + (int.Parse(primeirametade1) * int.Parse(segundametade2)) + (int.Parse(segundametade1) * int.Parse(primeirametade2)) + segundo;
            double solucao = (primeiro * Math.Pow(10, a)) + ((y - primeiro - segundo) * Math.Pow(10, (a / 2))) + segundo;
            txtResposta_1.Text = Convert.ToString(solucao);        }

        private void BtnCaulcularDig_Click(object sender, EventArgs e)
        {
              double k = Math.Pow(10, (int.Parse(txtNum2_2.Text) - 1));
              double l = Math.Pow(10, (int.Parse(txtNum1_2.Text)));
              l = l - 1;

              //textBox6.Text = ((int)Math.Pow(10, (int.Parse(textBox6.Text) - 1)), (int)Math.Pow(10, (int.Parse(textBox6.Text)))).ToString();
              //textBox7.Text = ((int)Math.Pow(10, (int.Parse(textBox7.Text) - 1)), (int)Math.Pow(10, (int.Parse(textBox7.Text)))).ToString();


              int tamanho = txtNum2_2.Text.Length;
              double a = tamanho;
              if (tamanho % 2 != 0)
              {
                  txtNum2_2.Text = "0" + txtNum2_2.Text;
                  tamanho = txtNum2_2.Text.Length;
                  a = tamanho;
              }
              string primeirametade1, segundametade1, primeirametade2, segundametade2;
              primeirametade1 = txtNum2_2.Text.Substring(0, (tamanho / 2));
              segundametade1 = txtNum2_2.Text.Substring((tamanho / 2), (tamanho / 2));


              tamanho = txtNum1_2.Text.Length;
              if (tamanho % 2 != 0)
              {
                txtNum1_2.Text = "0" + txtNum1_2.Text;
                  tamanho = txtNum1_2.Text.Length;
              }
              primeirametade2 = txtNum1_2.Text.Substring(0, (tamanho / 2));
              segundametade2 = txtNum1_2.Text.Substring((tamanho / 2), (tamanho / 2));

              int primeironum = (int.Parse(primeirametade1) * int.Parse(primeirametade2));
              int segundonum = (int.Parse(segundametade1) * int.Parse(segundametade2));

              int y = primeironum + (int.Parse(primeirametade1) * int.Parse(segundametade2)) + (int.Parse(segundametade1) * int.Parse(primeirametade2)) + segundonum;
              double solucao = (primeironum * Math.Pow(10, a)) + ((y - primeironum - segundonum) * Math.Pow(10, (a / 2))) + segundonum;
              txtResultado_2.Text = Convert.ToString(solucao);

        }
    }
}
