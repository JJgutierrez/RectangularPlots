using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    class RoateWriter : RotateRectanglesValues
    {
        public void Rotate(int angle, string textfile, string file)
        {
            double RotateX2 = ValueW(textfile) + RotateX(angle, textfile);
            double RotateY2 = ValueH(textfile) + RotateY(angle, textfile);
            List<double> p1 = new List<double>() { RotateX(angle, textfile), RotateY (angle, textfile)};
            List<double> p2 = new List<double>() { RotateX(angle, textfile), RotateY2 };
            List<double> p3 = new List<double>() { RotateX2, RotateY(angle, textfile) };
            List<double> p4 = new List<double>() { RotateX2, RotateY2 };

            StreamWriter rw = new StreamWriter(file);
            rw.WriteLine(" \nThe Coordinates for P1 is: {0} ", String.Join(";", p1));
            rw.WriteLine(" \nThe Coordinates for P2 is: {0} ", String.Join(";", p2));
            rw.WriteLine(" \nThe Coordinates for P3 is: {0} ", String.Join(";", p3));
            rw.WriteLine(" \nThe Coordinates for P4 is: {0} ", String.Join(";", p4));
            rw.Close();


        }
        public void writer()
        {
            Rotate(90, path1, @"Rotated90plot1.txt");
            Rotate(180, path1, @"Rotate180plot1.txt");
            Rotate(270, path1, @"Rotate270plot1.txt");

            Rotate(90, path2, @"Rotated90plot2.txt");
            Rotate(180, path2, @"Rotate180plot2.txt");
            Rotate(270, path2, @"Rotate270plot2.txt");

            Rotate(90, path3, @"Rotated90plot3.txt");
            Rotate(180, path3, @"Rotate180plot3.txt");
            Rotate(270, path3, @"Rotate270plot3.txt");


        }
    }
}
