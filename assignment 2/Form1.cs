using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                double volume = (length * width * height);
                label4.Text = "volume=" + volume;
            }
            catch {
                MessageBox.Show("Error on input");    }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {//
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                double volume = (length * width * height);
                label4.Text = "volume=" + volume;

            }
            catch
            {
                MessageBox.Show("Error on input");
            }
            try
            {
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                double surfacearea = 2.0 * (length * height + length * width + width * height);
                label5.Text = "SA=" + surfacearea;

            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }
    }
}
