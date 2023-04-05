using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormHistory : Form

    {
        public List<Personnel> listPersonnel = new List<Personnel>();
        public FormHistory()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 4)
                        {
                            Personnel personnel = new Personnel(
                                line[0],
                                line[1],
                                line[2],
                                line[3]

                            );
                            listPersonnel.Add(personnel);
                        }
                    }

                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPersonnel;
            }
        }

    }
}
