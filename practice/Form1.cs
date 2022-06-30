using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMI_Click(object sender, EventArgs e)
        {
           // double height = Convert.ToDouble(txtBHeight.Text);
           // double weight = Convert.ToDouble(txtBWeight.Text);
            double BMI;

            BMI = Convert.ToDouble(txtBWeight.Text) / Convert.ToDouble(txtBHeight.Text);

            if(BMI < 18)
            {
                MessageBox.Show("you are under weight!!");
            }

            if (BMI > 25)
            {
                MessageBox.Show("you are over weight!!");
            }
            else
            {
                MessageBox.Show("you are normal weight");
            }
        }
    }
}
