using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        List<Information> information;
        Information selectInformation;
        public Form3()
        {
            InitializeComponent();

            information = new List<Information>();
            information.Add(new Contact());
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectInformation = information[0];
            this.pictureBox1.Image = selectInformation.getImage();
            this.textBox1.Text = selectInformation.getName();
            this.textBox2.Text = selectInformation.getStudent();
            this.textBox3.Text = selectInformation.getFacebook();
            this.textBox4.Text = selectInformation.getEmail();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
