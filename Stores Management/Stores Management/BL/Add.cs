using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.BL
{
    class Add
    {
        public void Add_stors(string store_name, string address, string manager_name, string phone)
        {
            DL.Data_Access DL = new DL.Data_Access();
            SqlParameter[] SqlParameter = new SqlParameter[4];
            SqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = store_name;
            SqlParameter[1] = new SqlParameter("@Adress", SqlDbType.VarChar, 100);
            SqlParameter[1].Value = address;
            SqlParameter[2] = new SqlParameter("@Manager", SqlDbType.VarChar, 25);
            SqlParameter[2].Value = manager_name;
            SqlParameter[3] = new SqlParameter("@Phone", SqlDbType.VarChar, 15);
            SqlParameter[3].Value = phone;
            DL.open_server();
            DL.exe_command("add_new_store", SqlParameter);
        }

        public void Add_products(string id, string name, string store, string price, string production, string expiration)
        {
            DL.Data_Access DL = new DL.Data_Access();
            SqlParameter[] SqlParameter = new SqlParameter[6];
            SqlParameter[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = id;
            SqlParameter[1] = new SqlParameter("@Name", SqlDbType.VarChar, 25);
            SqlParameter[1].Value = name;
            SqlParameter[2] = new SqlParameter("@Store", SqlDbType.VarChar, 10);
            SqlParameter[2].Value = store;
            SqlParameter[3] = new SqlParameter("@Price", SqlDbType.VarChar, 25);
            SqlParameter[3].Value = price;
            SqlParameter[4] = new SqlParameter("@Production", SqlDbType.Date);
            SqlParameter[4].Value = production;
            SqlParameter[5] = new SqlParameter("@Expiration", SqlDbType.Date);
            SqlParameter[5].Value = expiration;
            DL.open_server();
            DL.exe_command("add_new_product", SqlParameter);
        }
    }
}
