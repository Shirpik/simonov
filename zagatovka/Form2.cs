using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zagatovka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            кнопка1 Check = new кнопка1();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            кнопка2 Check = new кнопка2();
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            кнопка3 Check = new кнопка3();
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            кнопка4 Check = new кнопка4();
            Check.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            кнопка5 Check = new кнопка5();
            Check.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            кнопка6 Check = new кнопка6();
            Check.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            кнопка7 Check = new кнопка7();
            Check.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
