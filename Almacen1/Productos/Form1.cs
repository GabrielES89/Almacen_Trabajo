using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Form1 : Form
    {
        int Caracter;
        string CadenaMac, CadenaCompleta;
        bool J = true;
        int Nuevo;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                Caracter++;
            }
            if (e.KeyChar == 8)
            {
                if (Caracter == 0)
                {
                    J = true;
                }
            }
        }

        private void textBox1_Layout(object sender, LayoutEventArgs e)
        {
            textBox1.Text = CadenaCompleta.ToUpper();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Caracter.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Caracter < 17)
            {
                if (char.IsLetterOrDigit(e.KeyChar))
                {
                    J = true;
                    Caracter++;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
            if (!(Caracter == 0))
            {
                if (e.KeyChar == 8)
                {
                    Caracter--;
                    e.Handled = false;
                    J = false;
                }
            }
            if (J)
            {
                if (Caracter % 3 == 0 && Caracter != 0)
                {
                    Caracter++;
                    textBox2.Text += ":";
                    textBox2.Select(textBox2.Text.Length, 1);
                    J = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Caracter = 0;
            }
            if (textBox1.Text.Length == 17)
            {
                Caracter = 0;
            }
            if (textBox1.Text.Length == 1)
            {
                J = false;
            }
            if (Caracter % 2 == 0 && Caracter != 0)
            {
                Caracter = 0;
                textBox1.Text += ":";
            }
            if (J)
            {
                J = false;
                Caracter = 1;
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.Select(textBox1.Text.Length, textBox1.Text.Length);
        }
    }
}
