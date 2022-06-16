using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorWebApi.Controllers
{
    public class ValuesController : ApiController
    {
      
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id.ToString();
        }

        [HttpPost]
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            string  mess = value + "  "+ " RETURN VAL";
            return mess;
        }

        //POST api/values/add/a&b
        //[HttpPost]
        //public int Add([FromBody] (int a, int b) parameters)
        //{
            
        //    return parameters.a - parameters.b;
        //}


    }
}
