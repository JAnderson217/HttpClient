using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class AccessWebService : IAccessWebService
    {
        public int getAdd(int firstNumber, int secondNumber)
        {
                try
                {
                string firstNumberString = firstNumber.ToString();
                string secondNumberString = secondNumber.ToString();
                var x = Task.Run(() => MainAsync(firstNumberString, secondNumberString));
                
                return x.Result;
                   
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                return 0;
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
                    var result = await client.PostAsync("Api/Values/Add/?a=" + first + "&b=" + second, null);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    
                    return Convert.ToInt16(resultContent);
                }
            }

        public int getSubtract(int firstNumber, int secondNumber)
        {
            try
            {
                string firstNumberString = firstNumber.ToString();
                string secondNumberString = secondNumber.ToString();
                var x = Task.Run(() => MainAsyncSub(firstNumberString, secondNumberString));
                
                return x.Result;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }
        static async Task<int> MainAsyncSub(string first, string second)
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
                var result = await client.PostAsync("Api/Values/Subtract/?a=" + first + "&b=" + second, null);
                string resultContent = await result.Content.ReadAsStringAsync();
                return Convert.ToInt16(resultContent);
            }
        }

        public int getMultiply(int firstNumber, int secondNumber)
        {
            try
            {
                string firstNumberString = firstNumber.ToString();
                string secondNumberString = secondNumber.ToString();
                var x = Task.Run(() => MainAsyncMult(firstNumberString, secondNumberString));

                return x.Result;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }
        static async Task<int> MainAsyncMult(string first, string second)
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
                var result = await client.PostAsync("Api/Values/Multiply/?a=" + first + "&b=" + second, null);
                string resultContent = await result.Content.ReadAsStringAsync();
                return Convert.ToInt16(resultContent);
            }
        }

        public int getDivide(int firstNumber, int secondNumber)
        {
            try
            {
                string firstNumberString = firstNumber.ToString();
                string secondNumberString = secondNumber.ToString();
                var x = Task.Run(() => MainAsyncDiv(firstNumberString, secondNumberString));

                return x.Result;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }
        static async Task<int> MainAsyncDiv(string first, string second)
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
                var result = await client.PostAsync("Api/Values/Divide/?a=" + first + "&b=" + second, null);
                string resultContent = await result.Content.ReadAsStringAsync();
                return Convert.ToInt16(resultContent);
            }
        }
    }
    }

