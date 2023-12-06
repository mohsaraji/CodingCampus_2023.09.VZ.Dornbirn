﻿using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DarioLuis.Week10.MySql
{
    public class MySQL_PreparedStatement
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=DarAndrad;password=Abruf!3300;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

                command.Parameters.AddWithValue("@Name", "%on");
                command.Parameters.AddWithValue("@Pop", 1000000);
                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void PrintResult(MySqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            for (int i = 0; i < header.Count; i++)
            {
                
                Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "[" + header[i].ColumnSize + "]   ");
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.Write(dataReader[i] + " |" +
                        " ");
                }
                Console.WriteLine();
            }
        }
    }
}

