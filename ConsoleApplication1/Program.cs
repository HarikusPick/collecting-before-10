using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 10;i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
           
        }
    }
}
