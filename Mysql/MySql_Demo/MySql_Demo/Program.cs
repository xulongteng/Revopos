using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySql_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "SELECT * FROM REV_Mql";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=revopos");
            MySqlCommand com = new MySqlCommand(str, con);
            con.Open();
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            string bookres = "";
            while (reader.Read()==true)
            {
                bookres += reader["ID"]+" ";
                bookres += reader["Name"]+ "  ";
                bookres += reader["Sex"]+"  ";
                bookres += reader["Age"]+ "  ";
            }
            reader.Close(); 
            con.Close();
            Console.WriteLine(bookres);
            Console.ReadLine();
        }
    }
}
