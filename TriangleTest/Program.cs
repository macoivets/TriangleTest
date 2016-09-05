using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;


namespace TriangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.txt");
            var f1=new Mas(15);
            f1.ReadArr("..\\..\\1.txt");
            

            Console.WriteLine("Max="+f1.FindPath());
            //f1.WriteArr();
            Console.WriteLine(" -------- ");

            Console.WriteLine("2.txt");
            var f2 = new Mas(100);
            f2.ReadArr("..\\..\\2.txt");

            Console.WriteLine("Max=" + f2.FindPath());

            Console.ReadLine();

        }
    }
}
