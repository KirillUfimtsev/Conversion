using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class ConversionNumbers
    {
        public string ConversionFrom10(int NumberBase, int Number)
        {
            switch (NumberBase)
            {
                case 2:
                    return Convert.ToString(Number, 2);
                case 8:
                    return Convert.ToString(Number, 8);
                case 16:
                    return Convert.ToString(Number, 16);
                default:
                    return Convert.ToString("Данная система счисления не существует");

            }
        }
    }
}
