using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo();
            Console.WriteLine("inserure lato 1");
            r.Lato1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire lato 2");
            r.Lato2 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire lato quadrato");
            r.LatoQuadrato = int.Parse(Console.ReadLine());
            r.CalcolaAreaPerimetro(r.Lato1,r.Lato2,r.LatoQuadrato);
            Console.WriteLine("Area e Perimetro Rettangolo:{0}, {1}",r.areaR, r.perimetroR);
            Console.WriteLine("Area e Perimetro Quadrato: {0}, {1}", r.areaQ, r.perimetroQ);
            Console.ReadLine();
     
        }
    }
}
