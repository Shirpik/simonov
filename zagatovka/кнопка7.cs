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
    public partial class кнопка7 : Form
    {
        public кнопка7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void кнопка7_Load(object sender, EventArgs e)
        {

        }
    }
}
