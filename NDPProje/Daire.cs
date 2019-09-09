using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NDPProje
{
    class Daire:Sekil
    {
        public double KenarUzunluk;
        public override void Ciz(Graphics g, SolidBrush b, int x, int y)
        {
            KenarUzunluk = (Math.Sqrt(Math.Pow(x - iX, 2.0) + Math.Pow(y - iY, 2.0))) / Math.Sqrt(2.0);
            Rectangle dortgen = new Rectangle(iX, iY, (int)KenarUzunluk, (int)KenarUzunluk);
            g.FillEllipse(b, dortgen);
        }
        public override void Sec(Graphics g, SolidBrush b, int x, int y)
        {
            KenarUzunluk = (Math.Sqrt(Math.Pow(sX - iX, 2.0) + Math.Pow(sY - iY, 2.0))) / Math.Sqrt(2.0);
            Rectangle dortgen = new Rectangle(iX, iY, (int)KenarUzunluk, (int)KenarUzunluk);

            if ((x >= iX && x <= sX && y >= iY && y <= sY))
            {
                g.FillRectangle(b,dortgen);
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
