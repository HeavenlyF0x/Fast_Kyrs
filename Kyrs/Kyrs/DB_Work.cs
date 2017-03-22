using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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


public class DB_Work
{
    public String connectionString = "";
    public Exception ex;
    public int ActivUser;
    public DB_Work()
    {
        connectionString = @"Data Source=TPUKCTEP; Initial Catalog=HotelsDB;Integrated Security=True";
    }

    public int AddNewUser(String _login, String _pass, String _lastname, String _firstname, String _patronymic, String _number)
    {

        String sqlExpression = "proc_Add_User";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@login", _login);
            command.Parameters.AddWithValue("@pass", _pass);
            command.Parameters.AddWithValue("@firstname", _firstname);
            command.Parameters.AddWithValue("@lastname", _lastname);
            command.Parameters.AddWithValue("@patronymic", _patronymic);
            command.Parameters.AddWithValue("@number", _number);
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

    public int AddClasses(String _idHotel, String _class, int _cost)
    {

        String sqlExpression = "proc_Add_Classes";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_hotel", _idHotel);
            command.Parameters.AddWithValue("@class", _class);
            command.Parameters.AddWithValue("@cost", _cost);
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

    public int AddHotel(String _idHotel, String _title,  String _address, int _startCount)
    {

        String sqlExpression = "proc_Add_Hotel";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_hotel", _idHotel);
            command.Parameters.AddWithValue("@title", _title);
            command.Parameters.AddWithValue("@address", _address);
            command.Parameters.AddWithValue("@starcount", _startCount);;
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

    public int AddNewUser(String _idHotel, String _idRoom, int _idClass)
    {

        String sqlExpression = "proc_Add_Room";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_hotel", _idHotel);
            command.Parameters.AddWithValue("@id_room", _idRoom);
            command.Parameters.AddWithValue("@id_class", _idClass);
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

    public int AddNewUser(String _idHotel, String _idRoom, int _idUser, String _dataIn, int _dayCount)
    {

        String sqlExpression = "proc_Add_Reservation";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_hotel", _idHotel);
            command.Parameters.AddWithValue("@id_room", _idRoom);
            command.Parameters.AddWithValue("@id_user", _idUser);
            command.Parameters.AddWithValue("@data_in", _dataIn);
            command.Parameters.AddWithValue("@day_count", _dayCount);
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

}

