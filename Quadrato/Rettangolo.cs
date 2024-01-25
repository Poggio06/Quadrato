using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrato
{
    internal class Rettangolo
    {
        public int Lato1 { get; set; }
        public int Lato2 { get; set; }
        public int LatoQuadrato { get; set; }
        public int areaR { get; set; }
        public int perimetroR { get; set; }
        public int areaQ { get; set; }
        public int perimetroQ { get; set; }

        public void CalcolaAreaPerimetro(int Lato1, int Lato2, int LatoQuadrato) 
        {
            areaR = Lato1 * Lato2;
            perimetroR = 2*Lato2 + 2*Lato1;
            areaQ = LatoQuadrato * LatoQuadrato;
            perimetroQ = 4 * LatoQuadrato;
            
            
        }
    }
}
