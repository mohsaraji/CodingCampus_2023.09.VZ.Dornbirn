﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week11
{
    internal class SQL_ConnectExample
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Mehmet;Password=Mehmet";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select *\r\n\tFrom City ci\r\n\tJoin Country c on c.Code = ci.Country\r\n\twhere c.Name = 'Austria'", connection);

                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();
                        for (int i = 0; i < header.Count; i++)
                        {
                            Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "[" + header[i].ColumnSize + "] | ");
                        }
                        Console.WriteLine();

                        while (reader.Read())
                        {
                            for (int i= 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader[i] + " | ");
                            }
                            Console.WriteLine(reader[0]);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
