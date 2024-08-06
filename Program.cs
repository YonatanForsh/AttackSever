using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AttackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //EX 1
            //string resolt =  await GetDataAsync();
            //Console.WriteLine(resolt);
            //Console.ReadLine();

            //EX2
            //string filePathToRead = "C:\\Users\\USER\\source\\repos\\AttackServer\\ExamFile.txt";
            //string res = await GetFileAsync(filePathToRead);
            //Console.WriteLine(res);
            //Console.ReadLine();

            //EX3
            Task<string> taskA = GetDataFromServiceAAsync();
            Task<string> taskB = GetDataFromServiceBAsync();
            await Task.WhenAll(taskA, taskB);
            Console.WriteLine(taskA.Result);
            Console.WriteLine(taskB.Result);
            Console.ReadLine();

        }

        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Data";
        }

        public static async Task<string> GetFileAsync(string filePath)
        {
            string path = @"C:\Users\USER\source\repos\AttackServer\ExamFile.txt";
            var text = await Task.Run(() => 
            File.ReadAllText(filePath));          
            return text;
        }

        static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "Data from service A";
        }

        static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(1000);
            return "Data from service B";
        }
    }
}
