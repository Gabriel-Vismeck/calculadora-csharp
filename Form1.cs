using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Globalization;
using calculadora_csharp.Properties;

namespace calculadora_csharp
{
    public partial class Form1 : Form
    {
        //Feito por Gabriel Vismeck

        //ÍNICIO DO FORMS
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            textBox1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            pictureBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 20, 20));
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button5.Height, 20, 20));
            button5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            button6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));
            button8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button8.Width, button8.Height, 20, 20));
            button9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 20, 20));
            button10.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button10.Width, button10.Height, 20, 20));
            button11.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button11.Width, button11.Height, 20, 20));
            button12.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button12.Width, button12.Height, 20, 20));
            button13.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button13.Width, button13.Height, 20, 20));
            button14.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button14.Width, button14.Height, 20, 20));
            button15.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button15.Width, button15.Height, 20, 20));
            button16.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button16.Width, button16.Height, 20, 20));
            button17.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button17.Width, button17.Height, 20, 20));
            button18.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button18.Width, button18.Height, 20, 20));

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private void exitButton_Click(object sender, EventArgs e)
        {
            fadeTimer.Start();
            
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0.0)
            {
                Opacity -= 0.025;
            }
            else
            {
                fadeTimer.Stop();
                Application.Exit();
            }
        }
        //FIM DO FORMS

        //COMEÇO DA CALCULADORA
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "ADIÇÃO";
                label1.Text = valor1 + "+";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de efetuar a conta.");
            }

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "SUBTRAÇÃO";
                label1.Text = valor1 + "-";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de efetuar a conta.");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "MULTIPLICAÇÃO";
                label1.Text = valor1 + "x";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de efetuar a conta.");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "MULTIPLICAÇÃO";
                label1.Text = valor1 + "÷";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de efetuar a conta.");
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora básica e estéticamente estilosa" + 
            Environment.NewLine + 
            Environment.NewLine + "Funciona como uma calculadora comum"+ "Instruções de uso: " +
            Environment.NewLine + "• Aperte nos número pra escolher os operandos." +
            Environment.NewLine + "• Aperte nos símbolos para escolher os operadores." +
            Environment.NewLine + "• Você não pode clicar num operador sem escolher um operando." +
            Environment.NewLine + "• CE apaga apenas a conta feita no visor, mas não a conta geral." +
            Environment.NewLine + "• C apaga toda a conta." +
            Environment.NewLine + Environment.NewLine + Environment.NewLine +"Feita por Gabriel Vismeck :)");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            
                switch (operacao)
                {
                    case "ADIÇÃO":
                        textBox1.Text = Convert.ToString(valor1 + valor2);
                        label1.Text = valor1 + "+" + valor2;
                        break;
                    case "SUBTRAÇÃO":
                            textBox1.Text = Convert.ToString(valor1 - valor2);
                        label1.Text = valor1 + "-" + valor2;
                        break;
                    case "MULTIPLICAÇÃO":
                        textBox1.Text = Convert.ToString(valor1 * valor2);
                        label1.Text = valor1 + "x" + valor2;
                        break;
                    case "DIVISÃO":
                        textBox1.Text = Convert.ToString(valor1 / valor2);
                        label1.Text = valor1 + "x" + valor2;
                        break;

                }

        }
        //FIM DA CALCULADORA
    }
}
