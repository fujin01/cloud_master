using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRZBD_Lab15
{
    class DataLoad
    {
        public void SetDataToDataGridView(DataGridView dataGridView, string query)
        {
            string connectionString = @" Data Source= ADCLG1; Initial catalog=Фрич_Нестерович_319/2; Integrated Security=True";
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //Указываем объекту DataAdapter, какие данные он должен получить и откуда
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            // Объект DataTable отслеживает и сохраняет в памяти изменения
            DataTable dt = new DataTable();
            // Теперь заполняем находящийся в памяти объект DataSet
            sda.Fill(dt);
            // Привязываем элемент DataGridView (визуальную таблицу) к хранящимся в памяти данным
            dataGridView.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
