using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NDPProje
{
    class Altıgen:Sekil
    {
        public float KenarUzunluk;
        public override void Ciz(Graphics g, SolidBrush b, int x, int y)
        {
            
            KenarUzunluk = (float)((Math.Sqrt(Math.Pow(x - iX, 2.0) + Math.Pow(y - iY, 2.0))) / Math.Sqrt(2.0)); //a(2 + 2kök3) 5,4641016151
            int c = (int)(KenarUzunluk / 5.4641016151);
            Point p1 = new Point(iX+c*2, iY);
            Point p2 = new Point(sX-c*2, iY);
            Point p3 = new Point(sX - c * 2, sY);
            Point p4 = new Point(iX+c*2, sY);
            Point p5 = new Point(sX,(sY+iY)/2);
            Point p6 = new Point(iX, (sY + iY) / 2);
            Point[] points = { p1, p2, p5, p3, p4,p6 };
            g.FillPolygon(b, points);
        }
        public override void Sec(Graphics g, SolidBrush b, int x, int y)
        {
            if ((x >= iX && x <= sX && y >= iY && y <= sY))
            {
                Point p1 = new Point(iX - 5, iY - 5);
                Point p2 = new Point(sX + 5, iY - 5);
                Point p3 = new Point(iX - 5, sY + 5);
                Point p4 = new Point(sX + 5, sY + 5);
                Point[] points = { p1, p2, p4, p3 };
                g.FillPolygon(b, points);
                kontrol++;

            }
            else if (x <= sX && x >= iX && y >= sY && y <= iY)
            {
                Point p1 = new Point(iX - 5, iY + 5);
                Point p2 = new Point(sX + 5, iY + 5);
                Point p3 = new Point(iX - 5, sY - 5);
                Point p4 = new Point(sX + 5, sY - 5);
                Point[] points = { p1, p2, p4, p3 };
                g.FillPolygon(b, points);
                kontrol++;
            }
            else if (x <= iX && x >= sX && y <= iY && y >= sY)
            {
                Point p1 = new Point(iX + 5, iY + 5);
                Point p2 = new Point(sX - 5, iY + 5);
                Point p3 = new Point(iX + 5, sY - 5);
                Point p4 = new Point(sX - 5, sY - 5);
                Point[] points = { p1, p2, p4, p3 };
                g.FillPolygon(b, points);
                kontrol++;
            }
            else if (x <= iX && x >= sX && y >= iY && y <= sY)
            {
                Point p1 = new Point(iX + 5, iY - 5);
                Point p2 = new Point(sX - 5, iY - 5);
                Point p3 = new Point(iX + 5, sY + 5);
                Point p4 = new Point(sX - 5, sY + 5);
                Point[] points = { p1, p2, p4, p3 };
                g.FillPolygon(b, points);
                kontrol++;
            }
        }

    }
}
