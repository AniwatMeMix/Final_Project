using System.Data;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class FormWork : Form
    {
        private List<Personnel> listPersonnel = new List<Personnel>();
        Personnel selectPersonnel;
        private Personnel New_personnel;




        public FormWork()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectPersonnel = (Personnel)row.DataBoundItem;


                this.TBname.Text = selectPersonnel.Name;
                this.TBln.Text = selectPersonnel.Lastname;
                this.TBwork.Text = selectPersonnel.Worker;
                this.TBtime.Text = selectPersonnel.Time;


            }
            string eName = selectPersonnel.Name, eLastname = selectPersonnel.Lastname, eWork = selectPersonnel.Worker, eTime = selectPersonnel.Time;
            selectPersonnel = new Personnel(eName, eLastname, eWork, eTime);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (Personnel item in listPersonnel)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3}",
                            item.Name,
                            item.Lastname,
                            item.Worker,
                            item.Time
                            ));
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = TBname.Text;
            string lastname = TBln.Text;
            string worker = TBwork.Text;
            string time = TBtime.Text;

            New_personnel = new Personnel(name, lastname, worker, time);


            Personnel NewPersonnel = getPersonnel();
            listPersonnel.Add(NewPersonnel);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = listPersonnel;

            this.TBname.Text = "";
            this.TBln.Text = "";
            this.TBwork.Text = "";
            this.TBtime.Text = "";



        }

        public Personnel getPersonnel() { return New_personnel; }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TimeIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}