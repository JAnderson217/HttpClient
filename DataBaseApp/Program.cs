using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("Enter first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Enter second number: ");
            string secondNumber = Console.ReadLine();

            Task.Run(() => MainAsync(firstNumber, secondNumber));

            Console.ReadLine();
        }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static async Task<int> MainAsync(string first, string second)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59135/");
                //var content = new FormUrlEncodedContent(new[]
                //{
                //    new KeyValuePair<string, string>("a", first),
                //    new KeyValuePair<string, string>("b", second)
                //});

                 //var result = await client.PostAsync("Api/Values/", content);
                 var resultAdd = await client.PostAsync("Api/Values/Add/?a=" + first + "&b=" + second, null);
                string resultContentAdd = await resultAdd.Content.ReadAsStringAsync();

                var resultSubtract = await client.PostAsync("Api/Values/Subtract/?a=" + first + "&b=" + second, null);
                string resultContentSubtract = await resultSubtract.Content.ReadAsStringAsync();

                var resultMultiply = await client.PostAsync("Api/Values/Multiply/?a=" + first + "&b=" + second, null);
                string resultContentMultiply = await resultMultiply.Content.ReadAsStringAsync();

                var resultDivide = await client.PostAsync("Api/Values/Divide/?a=" + first + "&b=" + second, null);
                string resultContentDivide = await resultDivide.Content.ReadAsStringAsync();

                Console.WriteLine("Add: "+ resultContentAdd);
                Console.WriteLine("Subtract: " + resultContentSubtract);
                Console.WriteLine("Multiply: " + resultContentMultiply);
                Console.WriteLine("Divide: " + resultContentDivide);
                return Convert.ToInt16(resultContentAdd);
            }
        }

    }
}
