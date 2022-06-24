using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    interface IWebServiceCalculator
    {
        int WebAdd(int start, int amount);
        int WebSubtract(int start, int amount);
        int WebMultiply(int start, int amount);
        int WebDivide(int start, int amount);

    }
}
