using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Stores_Management.BL
{
    class Data_Store
    {
        public DataTable select_All()
        { 
            DL.Data_Access dl = new DL.Data_Access();
            DataTable DataTable = new DataTable();
            DataTable = dl.select_data("select_data_of_store", null);
            return DataTable;
        }
    }
}
