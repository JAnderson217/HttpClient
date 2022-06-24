using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class WebServiceCalculator : IWebServiceCalculator
    {
        private IAccessWebService _accessWebService = null;

        public WebServiceCalculator(IAccessWebService accessWebService)
        {
            _accessWebService = accessWebService;

        }
        public int WebDivide(int start, int amount)
        {
            int WebService_Divide_Sum = _accessWebService.getDivide(start, amount);
            return WebService_Divide_Sum;
        }

        public int WebMultiply(int start, int amount)
        {
            int WebService_Multiply_Sum = _accessWebService.getMultiply(start, amount);
            return WebService_Multiply_Sum;
        }

        public int WebAdd(int start, int amount)
        {
            int WebService_Add_Sum = _accessWebService.getAdd(start, amount);
            return WebService_Add_Sum;
        }

        public int WebSubtract(int start, int amount)
        {
            int WebService_Subtract_Difference = _accessWebService.getSubtract(start, amount);
            return WebService_Subtract_Difference;
        }
    }
}
