using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class Calculator : ICalculator
    {
       private readonly IDiagnostics diag = null;
        private readonly IDBSave SaveToDB = null;
        //public Calculator() { }
        public Calculator(IDiagnostics diagnostics, IDBSave DBSave)
        {
            this.diag = diagnostics;
            this.SaveToDB = DBSave;
        }
        public int Add(int start, int amount)
        {
            int sum = start + amount;
            string sumString = sum.ToString();
            diag.Log(DateTime.Now + ":  Starting to Add using Console: " +sumString);
            SaveToDB.Save(DateTime.Now + ": Starting to Add to Database from stored procedure: " + sumString);

            return sum;
        }

        public int Divide(int start, int amount)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int start, int amount)
        {
            throw new NotImplementedException();
        }

        public int Sbtract(int start, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
