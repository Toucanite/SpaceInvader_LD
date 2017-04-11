using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvader_LD
{
    class Tir
    {
        PointF location;
        PointF initialLocation;
        PointF start;
        PointF end;

        Stopwatch sw;

        Size size = new Size(10,10);


        double d;
        double td;
        float verticalSpeed;
        float horizontalSpeed;
        float speed = 130;

        public Tir(PointF start, Rectangle zoneJeu)
        {
            this.start = start;
            this.end = new PointF(start.X, zoneJeu.Top);
            initialLocation = start;
            location = start;
            verticalSpeed = speed;
            sw = new Stopwatch();
            sw.Start();

            d = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
            td = d / speed;
            horizontalSpeed = (float)((end.X - start.X) / td);
            verticalSpeed = (float)((end.Y - start.Y) / td);
        }

        public PointF Location
        {
            get
            {
                return new PointF(initialLocation.X + horizontalSpeed * (float)(sw.ElapsedMilliseconds / 1000.0f),
                                  initialLocation.Y + verticalSpeed * (float)(sw.ElapsedMilliseconds / 1000.0f));
            }
        }


        public bool Stopped
        {
            get { return ((sw.ElapsedMilliseconds / 1000.0) >= td); }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            
            location = new PointF(  initialLocation.X + horizontalSpeed * (float)(sw.ElapsedMilliseconds / 1000.0f),
                                    initialLocation.Y + verticalSpeed * (float)(sw.ElapsedMilliseconds / 1000.0f));

            Rectangle recDessin = new Rectangle(Point.Round(location), size);

            e.Graphics.FillEllipse(Brushes.DimGray, recDessin);
            e.Graphics.DrawEllipse(Pens.DimGray, recDessin);
        }
    }
}
