using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fliper
{
    class Program
    {
        static void Main(string[] args)
        {
            char p;
            char r;
            Console.WriteLine("Informe P e R");
            string pr = Console.ReadLine();
            p = pr[0];
            r = pr[1];
            if( p == '0')
                Console.WriteLine("C");
            else
                if(r == '0')
                    Console.WriteLine("B");
                else
                    Console.WriteLine("A");
        }
    }
}
