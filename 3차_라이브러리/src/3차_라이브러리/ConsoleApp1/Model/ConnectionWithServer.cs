﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase
{
    public class ConnectionWithServer
    {
        private static MySqlConnection connection;
        private static MySqlConnection GetInstance()
        {
            if(connection == null)
            {
                connection = new MySqlConnection("Server=localhost;Port=3306;Database=bookstorage;Uid=root;Pwd=0000");
            }
            return connection;
        }

        public MySqlDataReader Select(string queryStatement) {

            MySqlCommand command = new MySqlCommand(queryStatement, GetInstance());
            MySqlDataReader readedData = command.ExecuteReader();
            return readedData;
        }

        public void CUD(string queryStatement)
        {
            MySqlCommand command = new MySqlCommand(queryStatement, GetInstance());
            command.ExecuteNonQuery();
        }
    }

}
