using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryhan_Tauani
{
    public partial class calculadora : Form
    {
        double primeiroNumero = 0;
        double segundoNumero = 0;
        string operacao = "";
  


        public calculadora()
        {
            InitializeComponent();
        }

        private void um_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";
           
        }

        private void dois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
           
        }

        private void tres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
            
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text += "4";
            
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text += "5";
           
        }

        private void seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text += "6";
           
        }

        private void sete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox2.Text += "7";
            
        }

        private void oito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text += "8";

        }

        private void nove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text += "9";
           
        }

        private void mais_Click(object sender, EventArgs e)
        {
            operacao = "+";
            primeiroNumero = double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "+";
           
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(textBox1.Text);
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    textBox2.Text = "=" + resultado.ToString();
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    textBox2.Text = "="+resultado.ToString();
                    break;
                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    textBox2.Text = "="+resultado.ToString();
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    textBox2.Text = "="+resultado.ToString();
                    break;
            }
            textBox1.Text = resultado.ToString();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operacao = "-";
            primeiroNumero = double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "-";
            
    }

        private void multi_Click(object sender, EventArgs e)
        {
            operacao = "*";
            primeiroNumero = double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "*";
            
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            primeiroNumero = double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "/";
        
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text += "0";
            

        }

        private void c_Click(object sender, EventArgs e)
        {
            primeiroNumero = 0;
            segundoNumero = 0;
            operacao = "";
            textBox1.Text = "";
            textBox2.Text = "";
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
