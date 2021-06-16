using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISI;
using System.Windows.Forms;

namespace FINALYCOURSEWORK
{ 
    public partial class Form1 : Form
    {
        public static string cAfter;
        public static string c;
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            cAfter = textBox1.Text;
            if (cAfter != c)
            {
                button1.Enabled = true;
            }
            textBox4.Text = null;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            c = textBox1.Text;
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            textBox4.Text = SISI.Class1.Number.TranslateToSystemNumbers(c, a, b);
            button1.Visible = false;
            button2.Visible = true;
            button2.Text = "РЕСТАРТ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
