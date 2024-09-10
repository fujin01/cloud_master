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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string query1 = "SELECT * FROM Предмет";
            string query2 = "SELECT * FROM Факультет";
            DataLoad dataLoad = new DataLoad();
            dataLoad.SetDataToDataGridView(dataGridView1, query1);
            dataLoad.SetDataToDataGridView(dataGridView2, query2);

            this.BackColor = Color.Salmon;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataGridView1.BackgroundColor = Color.Salmon;
            dataGridView2.BackgroundColor = Color.Salmon;
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
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM Предмет";
            string query2 = "SELECT * FROM Факультет";
            DataLoad dataLoad = new DataLoad();
            dataLoad.SetDataToDataGridView(dataGridView1, query1);
            dataLoad.SetDataToDataGridView(dataGridView2, query2);
        }
    }
}
