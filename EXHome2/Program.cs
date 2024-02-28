using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXHome2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.141592;
            raio = double.Parse(Console.ReadLine());
            double area = (raio * raio) * pi;
            Console.WriteLine("A=" + String.Format("{0:C4}", area) + "\n");
            Console.ReadKey();
        }
    }
}
