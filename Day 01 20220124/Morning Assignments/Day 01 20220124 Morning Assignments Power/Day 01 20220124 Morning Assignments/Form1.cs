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

        private void Button1_Click(object sender, EventArgs e)
        {
            int loop_index;
            long Power_Value;
            int Base_value = Convert.ToInt32(textBox1.Text);
            int Exponent_value = Convert.ToInt32(textBox2.Text);
            Power_Value = 1;
            for (loop_index = 1; loop_index < Exponent_value; loop_index++)
                Power_Value = Power_Value * Base_value;
            textBox3.Text = Power_Value.ToString();
        }
    }
}
