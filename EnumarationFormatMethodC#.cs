using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumarationFormatMethod
{
    enum Colors { Red, Green, Blue, Yellow };

    public class FormatTest
    {
        public static void Main()
        {
            Colors myColor = Colors.Blue;

            Console.WriteLine("My favorite color is {0}.", myColor);
            Console.WriteLine("The value of my favorite color is {0}.", Enum.Format(typeof(Colors), myColor, "d"));
            Console.WriteLine("The hex value of my favorite color is {0}.", Enum.Format(typeof(Colors), myColor, "x"));
        }
    }
}