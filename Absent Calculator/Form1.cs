using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absent_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doClear();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doCount();
        }


        private void doCount()
        {
            string text = textBox1.Text;
            int sum = 0, count = 0, sumA = 0, countA = 0;
            bool absent = false;
            foreach (char x in text.ToArray())
            {
                if (Char.IsNumber(x) && x != '0')
                {
                    if (absent)
                    {
                        countA++;
                        sumA += (int)Char.GetNumericValue(x);
                    }
                    count++;
                    sum += (int)Char.GetNumericValue(x);
                }
                if (x == '(')
                    absent = true;
                if (x == ')')
                    absent = false;
            }
            label5.Text = count.ToString();
            label6.Text = sum.ToString();
            label7.Text = countA.ToString();
            label8.Text = sumA.ToString();
        }
        private void doClear()
        {
            textBox1.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                doCount();
            if (e.KeyCode == Keys.Escape)
                doClear();

        }

    }
}
