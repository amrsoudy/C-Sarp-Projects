using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHiritage
{
    class Program
    {
        public static void Main()
        {


            Console.WriteLine("debut");
        }

    }
    class A
    {
      
        public virtual void moncalcul()
        {



        }
        public virtual void moToto()
        {


        }


    }
    class B : A
    {
        public override void moncalcul()
        {
            base.moncalcul();
        }
        public override void moToto()
        {


        }
        

    }
}
