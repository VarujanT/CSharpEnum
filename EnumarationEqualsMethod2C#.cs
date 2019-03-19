using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumarationEqualsMethod
{
    public enum SledDog
    {
        Unknown = 0, AlaskanMalamute = 1, Malamute = 1,
        Husky = 2, SiberianHusky = 2
    };

    public enum WorkDog { Unknown = 0, Newfoundland = 1, GreatPyrennes = 2 };

    public class Example
    {
        public static void Main()
        {
            SledDog dog1 = SledDog.Malamute;
            SledDog dog2 = SledDog.AlaskanMalamute;
            WorkDog dog3 = WorkDog.Newfoundland;

            Console.WriteLine("{0:F} ({0:D}) = {1:F} ({1:D}): {2}",
                              dog1, dog2, dog1.Equals(dog2));
            Console.WriteLine("{0:F} ({0:D}) = {1:F} ({1:D}): {2}",
                              dog1, dog3, dog1.Equals(dog3));
        }
    }
}