using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_01_20220124_Morning_Assignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int First_num = Convert.ToInt32(textBox1.Text);
            int Second_num = Convert.ToInt32(textBox2.Text);
            int Sum = First_num + Second_num;
            textBox3.Text = Sum.ToString();

        }
    }
}
