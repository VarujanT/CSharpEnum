using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumarationGetNamesMethod
{
    public class GetNamesTest
    {
        enum Colors { Red, Green, Blue, Yellow };
        enum Styles { Plaid, Striped, Tartan, Corduroy };

        public static void Main()
        {

            Console.WriteLine("The members of the Colors enum are:");
            foreach (string s in Enum.GetNames(typeof(Colors)))
                Console.WriteLine(s);

            Console.WriteLine();

            Console.WriteLine("The members of the Styles enum are:");
            foreach (string s in Enum.GetNames(typeof(Styles)))
                Console.WriteLine(s);
        }
    }
}