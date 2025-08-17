using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace диплом
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=WIN-LT83VHBUI9I\ZANAILHA;Initial Catalog=Klevyy_Zana;Integrated Security=True");

        public void openConnection()
        { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        
        }
        public void closedConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        
        }
        
        
        
        
    }
}
