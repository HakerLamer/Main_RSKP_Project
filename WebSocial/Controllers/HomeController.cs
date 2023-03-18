using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Html;
using System.Resources;

namespace WebSocial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        static public HtmlString BD()
        {
            string input="";
            
            string connectionString = Properties.Resources.ConnectBd;
            string sqlExpression = "Output_test";
            Console.WriteLine("Write Data");

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
                    input+=$"{reader.GetName(0)}  |  {reader.GetName(1)}  |  {reader.GetName(2)}";

                    while (reader.Read())
                    {
                        string Members = reader.GetString(0);
                        string Status = reader.GetString(1);
                        string Discipline = reader.GetString(2);
                        input+= $"<div>{Members}  |  {Status}  |  {Discipline}</div>";
                    }
                }
                else input="Not found";
            }
            return new HtmlString(input);
        }
    }
}
