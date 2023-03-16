using System;
using System.Diagnostics;
using System.IO;

namespace Main_RSKP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auth();
            Console.WriteLine("У тебя получилось!");
        }
        static void Auth()
        {
            string phpFilePath = "C:\\path\\to\\your\\file.php";
            string phpExecutablePath = "C:\\path\\to\\your\\php.exe"; // путь к исполняемому файлу PHP

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = phpExecutablePath;
            startInfo.Arguments = $"-S localhost:8000 -t \"{Path.GetDirectoryName(phpFilePath)}\""; // запускаем локальный сервер на порту 8000 и указываем корневую папку
            startInfo.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            // открываем браузер и переходим на страницу с нашим файлом
            Process.Start("http://localhost:8000/" + Path.GetFileName(phpFilePath));
        }
    }
}
