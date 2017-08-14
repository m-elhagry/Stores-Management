using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.BL
{
    class Update
    {
        public void update_stores(string new_store_name, string store_adress, string store_manager, string store_phone, string store_name)
        {
            DL.Data_Access dl = new DL.Data_Access();
            SqlParameter[] SqlParameter= new SqlParameter[5];
            SqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = new_store_name;
            SqlParameter[1] = new SqlParameter("@Adress", SqlDbType.VarChar, 100);
            SqlParameter[1].Value = store_adress;
            SqlParameter[2] = new SqlParameter("@Manager", SqlDbType.VarChar, 25);
            SqlParameter[2].Value = store_manager;
            SqlParameter[3] = new SqlParameter("@Phone", SqlDbType.VarChar, 15);
            SqlParameter[3].Value = store_phone;
            SqlParameter[4] = new SqlParameter("@x", SqlDbType.VarChar, 10);
            SqlParameter[4].Value = store_name;
            dl.open_server();
            dl.exe_command("update_store", SqlParameter);
        }
        public void products_update (string id, string name, string price, string Production_date, string Expiration_date, string x)
        {
            
            DL.Data_Access dl = new DL.Data_Access();
            SqlParameter[] SqlParameter = new SqlParameter[6];
            SqlParameter[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = id;
            SqlParameter[1] = new SqlParameter("@Name", SqlDbType.VarChar, 25);
            SqlParameter[1].Value = name;
            SqlParameter[2] = new SqlParameter("@Price", SqlDbType.VarChar, 25);
            SqlParameter[2].Value = price;
            SqlParameter[3] = new SqlParameter("@Production", SqlDbType.Date);
            SqlParameter[3].Value = Production_date;
            SqlParameter[4] = new SqlParameter("@Expiration", SqlDbType.Date);
            SqlParameter[4].Value = Expiration_date;
            SqlParameter[5] = new SqlParameter("@x", SqlDbType.VarChar, 25);
            SqlParameter[5].Value = x;
            dl.open_server();
            dl.exe_command("Up_Pro", SqlParameter);
        }
    }
}
