using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
            // chek upper elements
            if (text.Any(char.IsUpper))
            {

                upperCaseEvent.ForeColor = Color.LightBlue;
            }
            else
            {
                upperCaseEvent.ForeColor = Color.Black;
            }
            // chek lower elements
            if (text.Any(char.IsLower))
            {
                label3.ForeColor = Color.LightBlue;
            }
            else
            {
                label3.ForeColor = Color.Black;
            }
            // chek number
            if (text.Any(char.IsNumber))
            {
                label5.ForeColor = Color.LightBlue;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
            //chek symbol
            if (text.Any(char.IsSymbol) | text.Any(char.IsPunctuation))
            {
                label4.ForeColor = Color.LightBlue;
            }else
            {
                label4.ForeColor = Color.Black;
            }
            // chek length 8 charachter
            if (text.Length > 7)
            {
                label6.ForeColor = Color.LightBlue;
            }
            else
            {
                label6.ForeColor = Color.Black;
            }
        }

       


    }
}