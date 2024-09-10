using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRZBD_Lab15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string query = "SELECT * FROM Специальность";
            DataLoad dataLoad = new DataLoad();
            dataLoad.SetDataToDataGridView(dataGridView1, query);

            this.BackColor = Color.Salmon;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataGridView1.BackgroundColor = Color.Salmon;
            this.Font = new Font("Comic Sans MS", 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Специальность";
            DataLoad dataLoad = new DataLoad();
            dataLoad.SetDataToDataGridView(dataGridView1, query);
        }
    }
}
