using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumarationGetUnderlyingTypeMethod
{
    public class Example
    {
        public static void Main()
        {
            Enum[] enumValues = { ConsoleColor.Red, DayOfWeek.Monday,
                            MidpointRounding.ToEven, PlatformID.Win32NT,
                            DateTimeKind.Utc, StringComparison.Ordinal };
            Console.WriteLine("{0,-10} {1, 18}   {2,15}\n",
                              "Member", "Enumeration", "Underlying Type");
            foreach (var enumValue in enumValues)
                DisplayEnumInfo(enumValue);
        }

        static void DisplayEnumInfo(Enum enumValue)
        {
            Type enumType = enumValue.GetType();
            Type underlyingType = Enum.GetUnderlyingType(enumType);
            Console.WriteLine("{0,-10} {1, 18}   {2,15}",
                              enumValue, enumType.Name, underlyingType.Name);
        }
    }
}