using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kyrs
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source=TPUKCTEP-ПК; Initial Catalog=SQL_Test;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region button1
            /*
            string sqlExpression = "add_info_in";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                command.Parameters.AddWithValue("@string", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@number", int.Parse(textBox2.Text));
                //command.Parameters.AddWithValue("@data)", textBox3.Text.ToString());
                //var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                var result = command.ExecuteNonQuery();
                this.get_my_strings_slonTableAdapter.Fill(this.sQL_TestDataSet.get_my_strings_slon);
            }
            */
            #endregion 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
