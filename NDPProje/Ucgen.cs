using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NDPProje
{
    class Ucgen:Sekil
    {
        public override void Ciz(Graphics g, SolidBrush b, int x, int y)
        {
            Point point = new Point((iX+ sX)/2, iY);
            Point point2 = new Point(sX, sY);
            Point point3 = new Point(iX,sY);
            Point[] points = { point, point2, point3 };
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
