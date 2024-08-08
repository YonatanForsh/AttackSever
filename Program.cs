using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AttackServer;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string JsonPath = @"C:\Users\USER\source\repos\AttackServer\missiles.json";

            List<Missile> a = JsonController.ReadJson(JsonPath);

            //Console.WriteLine(a.ToArray()); 


            string reader = await ReadFileAsync(JsonPath);
            Dictionary<string, int> missilesDict = new Dictionary<string, int>
            {
                {"Qassam-1" , 50},
                {"M-75" , 100} ,
                {"Fajr-5" , 150},
                {"Kornet" , 30 }
            };

           




            // ex1
            //string result = await GetDataAsync();
            //  Console.WriteLine(result);
            //  Console.ReadLine();

            // ex 2
            //string filePathToRead = "C:\\Users\\Omer Munk\\source\\repos\\attackServer\\instructions.txt";
            //string content = await ReadFileAsync(filePathToRead);
            //Console.WriteLine(content);


            // ex3

            //Task<string> TaskA = GetDataFromServiceAAsync();
            //Task<string> TaskB = GetDataFromServiceBAsync();
            //await Task.WhenAll(TaskA, TaskB);
            //Console.WriteLine($"Task A result: {TaskA.Result}");
            //Console.WriteLine($"Task B result: {TaskB.Result}");

            //EX4
            //Node<double> node2 = new Node<double>(5.5);
            //Node<double> node3 = new Node<double>(20.5, node2);
            //Console.WriteLine(node2);
            //Console.WriteLine(node3);

            //EX5
            Dictionary<string, int> friends = new Dictionary<string, int>();
            friends.Add("Avi", 30);
            friends.Add("Yony", 25);
            friends.Add("David", 33);
            friends.Add("Moshe", 18);


        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";
        }

        public static async Task<string> ReadFileAsync(string filePath)
        {
            string result = await Task.Run(
                () => File.ReadAllText(filePath)
                );
            return result;

        }

        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "Data from Service A";
        }


        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "Data from Service B";
        }
    }
}