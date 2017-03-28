using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


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

    public int AddHotel(String _idHotel, String _title, String _address, int _startCount)
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
            command.Parameters.AddWithValue("@starcount", _startCount); ;
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

    public int AddRoom(String _idHotel, String _idRoom, int _idClass)
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

    public int AddReservation(String _idHotel, String _idRoom, int _idUser, DateTime _dataIn, DateTime _dateOut)
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
            command.Parameters.AddWithValue("@data_out", _dateOut);
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

    public DataGridView FillHotel(DataGridView _dgv)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "proc_Select_Hotels";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public int GetLogin(String _login, String _pass)
    {
        int i = 1;

        String sqlExpression = "proc_Login";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@login", _login);
            command.Parameters.AddWithValue("@pass", _pass);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            ActivUser = int.Parse(reader["Id_User"].ToString());
        }
        catch (Exception _ex)
        {
            ex = _ex;
            i = -1;
        }
        finally
        {
            connection.Close();
        }
        return i;
    }

    public DataGridView FillReservation(DataGridView _dgv, int _idUser)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "proc_Select_My_Reservation";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", _idUser);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public ComboBox FiilBoxIdHotel(ComboBox _cb)
    {
        ComboBox cb = _cb;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hotel", connection);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            cb.DataSource = tbl;
            cb.DisplayMember = "Id_Hotel";
            cb.ValueMember = "id";
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return cb;
    }

    public ComboBox FillBoxClass(ComboBox _cb)
    {
        ComboBox cb = _cb;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room_Classes", connection);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            cb.DataSource = tbl;
            cb.DisplayMember = "Id_Class";
            cb.ValueMember = "id";
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return cb;
    }

    public ComboBox FillBoxUser(ComboBox _cb)
    {
        ComboBox cb = _cb;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users_", connection);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            cb.DataSource = tbl;
            cb.DisplayMember = "Id_User";
            cb.ValueMember = "id";
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return cb;
    }

    public DataGridView FillRoom(DataGridView _dgv)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "SELECT * FROM Room";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public DataGridView FillRoomClasses(DataGridView _dgv)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "SELECT * FROM Room_Classes";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public DataGridView FillLogins(DataGridView _dgv)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "SELECT * FROM Users_ WHERE Id_User <> 1";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public DataGridView FillFree(DataGridView _dgv, String _idHotel, DateTime _dataIn, DateTime _dataOut)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "proc_Select_Free";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_hotel", _idHotel);
            command.Parameters.AddWithValue("@data_in", _dataIn);
            command.Parameters.AddWithValue("@data_out", _dataOut);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public DataGridView FillLog(DataGridView _dgv)
    {
        DataGridView dgv = _dgv;

        String sqlExpression = "SELECT * FROM Reg_Log";

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        catch (Exception _ex)
        {
            ex = _ex;
        }
        finally
        {
            connection.Close();
        }
        return dgv;
    }

    public int DeleteMyReservation(int _idReservation)
    {
        String sqlExpression = "proc_DeleteMyResrv";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_reserv", _idReservation);
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

    public int ClearOldReservation()
    {
        String sqlExpression = "proc_Clear_Old_Reservations";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            var result = command.ExecuteNonQuery();
        }
        catch (Exception _ex)
        {
            ex = _ex;
            info = -1;
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            connection.Close();
        }
        return info;
    }

    public int DeleteHotel(String _idHotel)
    {
        String sqlExpression = "proc_Delete_Hotel";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHotel", _idHotel);
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

    public int DeleteRoom(String _idHotel, String _idRoom)
    {
        String sqlExpression = "proc_Delete_Room";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHotel", _idHotel);
            command.Parameters.AddWithValue("@idRoom", _idRoom);
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

    public int DeleteRoomClass(String _idHotel, int _idClass)
    {
        String sqlExpression = "proc_Delete_Room_Class";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHotel", _idHotel);
            command.Parameters.AddWithValue("@idClass", _idClass);
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

    public int DeleteUser(int _idUser)
    {
        String sqlExpression = "proc_Delete_User";

        int info = 0;

        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idUser", _idUser);
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
