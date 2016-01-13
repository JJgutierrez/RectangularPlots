using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace GardenRental
{
    class RotateRectanglesValues: XYValues
    {
        public  double  RotateX(int angle, string route)
        {
            double X = Math.Cos(angle) * ValueX(route) - Math.Sin(angle) * ValueY(route);
            return Math.Round(X);
        }

        public double RotateY(int angle, string route)
        {
            double Y = Math.Sin(angle) * ValueX(route) + Math.Cos(angle) * ValueY(route);
            return Math.Round(Y);
        }

      

    }
}
