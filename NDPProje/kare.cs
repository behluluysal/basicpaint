using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    class Kare : Sekil
    {
        public override void Ciz(Graphics g, SolidBrush b, int x, int y)
        {
            Point p1 = new Point(iX, iY);
            Point p2 = new Point(sX, iY);
            Point p3 = new Point(iX, sY);
            Point p4 = new Point(sX, sY);
            Point[] points = { p1, p2, p4, p3 };
            g.FillPolygon(b, points);
        }
        public override void Sec(Graphics g, SolidBrush b, int x, int y)
        {
            if((x >= iX && x <=sX && y >= iY && y <= sY ))
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
            else if(x<=iX && x>=sX && y<= iY && y>= sY)
            {
                Point p1 = new Point(iX + 5, iY + 5);
                Point p2 = new Point(sX - 5, iY + 5);
                Point p3 = new Point(iX + 5, sY - 5);
                Point p4 = new Point(sX - 5, sY - 5);
                Point[] points = { p1, p2, p4, p3 };
                g.FillPolygon(b, points);
                kontrol++;
            }
            else if(x<= iX&&x>=sX&&y>=iY&&y<=sY)
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
