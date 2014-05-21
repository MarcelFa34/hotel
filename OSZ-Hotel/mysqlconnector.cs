using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace OSZ_Hotel
{
    class mysqlconnector
    {

        public Dictionary<string,string> asdf = new Dictionary<string,string>();
        public mysqlconnector()
        {


            string myConnectionString = this.getConnectionString("localhost","fbvoteapp","sa","Klmr45a");
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM test";
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                asdf.Add(Reader["id"].ToString(),Reader["name"].ToString());  
            }
            connection.Close();

        }
        public string getConnectionString(string dbServer, string dbDatabase, string dbUsername, string dbPassword)
        {
            string temp = string.Empty;
            temp = "Data Source=" + dbServer + ";Initial Catalog=" + dbDatabase + ";User ID=" + dbUsername + ";Password=" + dbPassword + ";Connection Timeout=10";
            return temp;
        }

    }
}
