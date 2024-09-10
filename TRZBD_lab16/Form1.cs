using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRZBD_lab16
{
    public partial class Form1 : Form
    {
        string connectionString = @" Data Source= ADCLG1; Initial catalog=Фрич_Нестерович_319/2; Integrated Security=True";
        SqlConnection sqlConnection;
        
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }
  
        private void button1_Click(object sender, EventArgs e) //добавить
        {
            string query = "INSERT INTO Bibl VALUES(@name, @artist, @count, @year)";
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.Parameters.AddWithValue("@artist", textBox2.Text);
            command.Parameters.AddWithValue("@count", Convert.ToInt32(textBox3.Text));
            command.Parameters.AddWithValue("@year", Convert.ToInt32(textBox4.Text));
            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            this.biblTableAdapter.Fill(this._Фрич_Нестерович_319_2DataSet.Bibl);
        }

        private void button2_Click(object sender, EventArgs e) //удалить
        {
            string query = "DELETE FROM Bibl WHERE id = @id";
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox5.Text));
            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            this.biblTableAdapter.Fill(this._Фрич_Нестерович_319_2DataSet.Bibl);
        }

        private void button3_Click(object sender, EventArgs e) //изменить
        {
            string query = "UPDATE Bibl SET Bibl.Название = @name, Bibl.Автор = @artist, Bibl.количество_страниц = @count,  Bibl.год = @year WHERE Bibl.id = @id";
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox10.Text));
            command.Parameters.AddWithValue("@name", textBox9.Text);
            command.Parameters.AddWithValue("@artist", textBox8.Text);
            command.Parameters.AddWithValue("@count", Convert.ToInt32(textBox7.Text));
            command.Parameters.AddWithValue("@year", Convert.ToInt32(textBox6.Text));
            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            this.biblTableAdapter.Fill(this._Фрич_Нестерович_319_2DataSet.Bibl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Фрич_Нестерович_319_2DataSet.Bibl". При необходимости она может быть перемещена или удалена.
            this.biblTableAdapter.Fill(this._Фрич_Нестерович_319_2DataSet.Bibl);

        }
    }
}
