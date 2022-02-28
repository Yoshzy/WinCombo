using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinCombo.Src
{
    internal class Data
    {
     public  MySqlConnection conn;

       public Data()
        {
            conn = new MySqlConnection("datasource=localhost;port=3306;database=combo;username=root;password=root;SslMode=none");
        }

        public MySqlConnection GetMySqlConnection()
        {
            return conn;
        }
    }
}
