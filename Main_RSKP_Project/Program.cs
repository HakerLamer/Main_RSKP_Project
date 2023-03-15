using System;
using System.Net;
using System.Diagnostics;
namespace Main_RSKP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\xampp\htdocs\laba2\third.php";
            Process.Start(
            new ProcessStartInfo(path) 
            { 
                UseShellExecute = true 
            }
            );
        }
    }
}
