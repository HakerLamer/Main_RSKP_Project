using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace Main_RSKP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string log = "error.logs.txt";
            string connectionString = @"Data Source=localhost;Initial Catalog=VladBase;Integrated Security=True";
            string sqlExpression = "Output_test";
            Console.WriteLine("Write Data");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    // параметр для ввода имени
                    SqlParameter nameParam = new SqlParameter
                    {
                        ParameterName = "@Text",
                        Value = Console.ReadLine(),
                    };
                    // добавляем параметр
                    command.Parameters.Add(nameParam);
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                        while (reader.Read())
                        {
                            string Members = reader.GetString(0);
                            string Status = reader.GetString(1);
                            string Discipline = reader.GetString(2);
                            Console.WriteLine("{0} {1} {2}", Members, Status, Discipline);
                        }
                    }
                    else Console.WriteLine("Not found");
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("error.logs.txt", DateTime.Now + "\n" + ex.Message + "\n" + ex + "\n" + "\n" + "\n");
            }

        }
    }
}
