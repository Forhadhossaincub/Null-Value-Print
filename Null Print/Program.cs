using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? n = null;

            Console.WriteLine(n.ToString());


            if (n.HasValue)
            {
                Console.WriteLine(n.Value);
            }

            else
            {
                Console.WriteLine("Null");
            }


            Console.ReadKey();
        }
    }
}
