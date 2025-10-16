using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


using MySql.Data.MySqlClient;


namespace Zooka

{

    public class Conexao

    {

        public static string connString = "server=10.37.44.26;user id=root;password=root;database=Zooka";

        public MySqlConnection GetConnection()

        {


            return new MySqlConnection(connString);

        }


    }


}