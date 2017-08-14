using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.BL
{
    class Delete
    {
        public void delete_store(string store_name)
        {
            DL.Data_Access dl = new DL.Data_Access();
            SqlParameter[] SqlParameter = new SqlParameter[1];
            SqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = store_name;
            dl.open_server();
            dl.exe_command("delete_store", SqlParameter);
        }
        public void delete_product(string product_name)
        {
            DL.Data_Access dl = new DL.Data_Access();
            SqlParameter[] SqlParameter = new SqlParameter[1];
            SqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = product_name;
            dl.open_server();
            dl.exe_command("delete_product", SqlParameter);
        }
    }
}
