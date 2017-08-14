using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.DL
{
    class Data_Access
    {
        SqlConnection SqlConnection;
        public Data_Access()
        {
            SqlConnection = new SqlConnection("Server = .; DataBase=store manage;Integrated Security=true;");
        }
        public void close_server()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public void open_server()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }
        public DataTable select_data(string stored_procesure,SqlParameter[] SqlParameter)
        {
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.CommandType = CommandType.StoredProcedure;
            SqlCommand.CommandText = stored_procesure;
            SqlCommand.Connection = SqlConnection;
            if (SqlParameter != null)
            {
                SqlCommand.Parameters.AddRange(SqlParameter);
            }
            SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlCommand);
            DataTable DataTable = new DataTable();
            DataAdapter.Fill(DataTable);
            return DataTable;
        }
        public void exe_command(string stored_procesure, SqlParameter[] SqlParameter)
        {
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.CommandText = stored_procesure;
            SqlCommand.CommandType = CommandType.StoredProcedure;
            SqlCommand.Connection = SqlConnection;
            if (SqlParameter != null)
            {
                SqlCommand.Parameters.AddRange(SqlParameter);
            }
            SqlCommand.ExecuteNonQuery();
        }

    }
}
