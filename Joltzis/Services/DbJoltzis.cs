using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joltzis {
    public class DbJoltzis {
        SqlConnection SqlCon = new SqlConnection();

        public DbJoltzis() {
            SqlCon.ConnectionString = @"Data Source=SQO-106\MSSQLSERVER01;Initial Catalog=Joltzis;Integrated Security=True";
        }


        public SqlConnection OpenConection() {

            if (SqlCon.State == ConnectionState.Closed) {
                SqlCon.Open();
            }

            return SqlCon;
        }

        public SqlConnection CloseConnection() {
            if (SqlCon.State == ConnectionState.Open) {
                SqlCon.Close();
            }

            return SqlCon;

        }
    }
}
