using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        //enum Day { Sat = 1, Sun = 2, Mon = 3, Tue = 4, Wed = 5, Thu = 6, Fri = 7 };

        static void Main(string[] args)
        {


            Console.WriteLine("ecrire  un num 1 - 7 ");
            int num = int.Parse(Console.ReadLine());


            // string stringValue = Enum.GetName(typeof(Day), num);
            CultureInfo current = CultureInfo.CurrentUICulture;


            if (current.Name == "fr-FR")
            {


                String StringV = current.DateTimeFormat.DayNames[num];

                Console.WriteLine(StringV);


            }


            else if (current.Name == "en-EN")
            {



                String StringV = current.DateTimeFormat.DayNames[num];

                Console.WriteLine(StringV);


            }


        }


        //switch (num)
        //{

        //    case (int)Day.Sat:
        //        Console.WriteLine(num + "lundi ");
        //        break;
        //    case (int)Day.Sun:
        //        Console.WriteLine(num + "mardi ");
        //        break;

        //    case (int)Day.Mon:
        //        Console.WriteLine(num + "mercredi ");
        //        break;
        //    case (int)Day.Tue:
        //        Console.WriteLine(num + "joody ");
        //        break;
        //    case (int)Day.Wed:
        //        Console.WriteLine(num + "vend ");
        //        break;
        //    case (int)Day.Thu:
        //        Console.WriteLine(num + "samd ");
        //        break;
        //    case (int)Day.Fri:
        //        Console.WriteLine(num + "dim ");
        //        break;


        //}

        //  }
    }
}
