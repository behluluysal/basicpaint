using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NDPProje
{
    abstract class Sekil
    {
        public static int kontrol = 0;
        public  string adi { get; set; }
        public  Color renk { get; set; }

        public  int iX { get; set; }
        public  int iY { get; set; }
        public  int sX { get; set; }
        public  int sY { get; set; }
        public int iY1 { get; set; }


        public abstract void Ciz(Graphics g, SolidBrush b, int x, int y);
        public abstract void Sec(Graphics g, SolidBrush b, int x, int y);
        
    }
}
