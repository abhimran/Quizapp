using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (optYes.Checked == true)
            {
                MessageBox.Show("Correct Answer!");
            }
            else
                MessageBox.Show("False! Please Check Your answer again!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
