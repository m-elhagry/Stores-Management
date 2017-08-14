using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.BL
{
    class data_products
    {
        public DataTable select_by_store(string store_name)
        {
            DL.Data_Access DL = new DL.Data_Access();
            SqlParameter[] SqlParameter= new SqlParameter[1];
            SqlParameter[0] = new SqlParameter("@store", SqlDbType.VarChar, 10);
            SqlParameter[0].Value = store_name;
            return (DL.select_data("select_all_products_by_store", SqlParameter));          
        }
    }
}
