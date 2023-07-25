using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Mudgett, T
namespace summer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem as string;
            MessageBox.Show(textBox1.Text, "My name is");
            if (selectedItem == "Dog")
            {
                Dog.Visible = true;
                Cat.Visible = false;

            }
            else if (selectedItem == "Cat")
            {
                Cat.Visible = true;
                Dog.Visible = false;
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}