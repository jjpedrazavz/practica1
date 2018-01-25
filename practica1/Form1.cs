using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbx_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

            if (!txtInput.Text.Contains("."))
            {
                txtInput.Text += ".";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtResult.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtInput.TextLength>0)
            txtInput.Text = txtInput.Text.Substring(0, txtInput.TextLength - 1);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (cboxOrigen.SelectedItem.ToString().Equals("pie"))
            {
                if (cboxDestino.SelectedItem.ToString().Equals("pulg"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 12).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("cm"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 30.48).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("m"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 0.3048).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("mi"))
                {
                    txtResult.Text = "Conversion no valida!";
                }
            }
            else if (cboxOrigen.SelectedItem.ToString().Equals("cm"))
            {
                if (cboxDestino.SelectedItem.ToString().Equals("pie"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 0.03280).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("cm"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 1).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("m"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 0.01).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("pulg"))
                {
                    txtResult.Text = (double.Parse(txtInput.Text) * 0.3937).ToString();
                }
                else if (cboxDestino.SelectedItem.ToString().Equals("mi"))
                {
                    txtResult.Text = "Conversion no valida!";
                }
            }

        }

        private void cboxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}
