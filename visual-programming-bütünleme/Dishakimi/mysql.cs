using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dishakimi
{
    class mysql
    {
        static void mymethod()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        }
      
    }
}
