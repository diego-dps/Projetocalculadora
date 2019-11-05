using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2, resultado;
        char operacao;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true; //o ReadOnly é somente leitura
            textBox2.Enabled = false; //desabilita ou habilita
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            textBox2.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            textBox2.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            textBox2.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            textBox2.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            textBox2.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            textBox2.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            textBox2.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            textBox2.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            textBox2.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            textBox2.Text += 0;
        }

        private void buttondivisao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(textBox2.Text);
                if (valor1 == 0 || valor1 < 0)
                {
                    MessageBox.Show("valor inválido");
                }
                else
                {
                    textBox1.Text += "/";
                    operacao = '/';
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("operação inválida");
            }
            
            
        }

        private void buttonmultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(textBox2.Text);
                textBox1.Text += "*";
                operacao = '*';
                textBox2.Clear();
            }
            catch
            {
                MessageBox.Show("operação inválida");
            }
            
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = double.Parse(textBox2.Text);
                switch (operacao)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        break;

                    case '-':
                        resultado = valor1 - valor2;
                        break;

                    case '*':
                        resultado = valor1 * valor2;
                        break;

                    case '/':
                        if (valor1 == 0 || valor1 < 0 || valor2 == 0 || valor2 < 0)
                        {
                            MessageBox.Show("valor inválido");
                        }
                        else
                        {
                            resultado = valor1 / valor2;
                        }
                        break;

                    case '%':
                        try
                        {
                            resultado = (valor1 / 100) * valor2;
                            break;
                        }
                        catch
                        {
                            MessageBox.Show("operação inválida");
                        }
                        break;


                }

                textBox2.Clear();
                textBox2.Text = resultado.ToString();
                textBox1.Text += "=" + resultado;
            }
            catch
            {
                MessageBox.Show("operação inválida");
            }
            
        }

        private void buttondeletar_Click(object sender, EventArgs e)
        {
            try // quando entra em uma exeção ele executa o bloco "cath";
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox2.Clear();
            }
            catch
            {
                MessageBox.Show("Visor vazio!", "Calculadora diz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttondesligar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonponto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
            textBox2.Text += ',';

        }

        private void buttonporcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(textBox2.Text);
                textBox1.Text += "%";
                operacao = '%';
                textBox2.Clear();
            }
           
            catch
            {
                MessageBox.Show("operação inválida");
            }
        }

        private void buttonsubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(textBox2.Text);
                textBox1.Text += "-";
                operacao = '-';
                textBox2.Clear();
            }
            catch
            {
                MessageBox.Show("operação inválida");
            }


        }

        private void buttonadicao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(textBox2.Text);
                textBox1.Text += "+";
                operacao = '+';
                textBox2.Clear();
            }
            
            catch
            {
                MessageBox.Show("operação inválida");
            }
        }
    }
}
