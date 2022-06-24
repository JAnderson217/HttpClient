using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Autofac container
            var builder = new ContainerBuilder();
            var builderWebService = new ContainerBuilder();

            builder.RegisterType<Diagnostics>().As<IDiagnostics>();
            builder.RegisterType<Calculator>().As<ICalculator>();
            builder.RegisterType<DBSave>().As<IDBSave>();

            builderWebService.RegisterType<AccessWebService>().As<IAccessWebService>();
            builderWebService.RegisterType<WebServiceCalculator>().As<IWebServiceCalculator>();
            var container = builder.Build();
            var WebServiceContiner = builderWebService.Build();

            var diag = container.Resolve<IDiagnostics>();
            var cal = container.Resolve<ICalculator>();
            var db = container.Resolve<IDBSave>();

            var WebCalc = WebServiceContiner.Resolve<IWebServiceCalculator>();
            //var WebService = WebServiceContiner.Resolve<IAccessWebService>();
            int sum = cal.Add(30, 6);
            int WebDifference = WebCalc.WebSubtract(30, 6);
            int WebSum = WebCalc.WebAdd(6, 6);
            int WebMult = WebCalc.WebMultiply(7, 7);
            int WebDiv = WebCalc.WebDivide(WebDifference, WebSum);
            string results = $"Web Service results: WebSum: {WebSum}, WebDifference: {WebDifference}, WebMultiply: {WebMult}, Web" +
                $"Divide: {WebDiv}";
            Console.WriteLine(results);
            //save results to DB
            db.Save(results);

            //IDiagnostics diagnostics = new Diagnostics();
           // Calculator myCalc = new Calculator(diagnostics);
           // int sum = myCalc.Add(3, 4);
            Console.WriteLine("sum:(internal) {0}", sum);
            Console.ReadLine();
        }
    }
}
