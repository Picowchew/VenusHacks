using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revised_Venus_Hackathon_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBoxs2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonimage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = open.FileName;
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void buttonlt_Click(object sender, EventArgs e)
        {

        }
    }
}
