using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
     class FencingPerimeter: XYValues
    {
        public int Perimeter(string p)
        {
            int peri = ValueW(p) * 2 + ValueH(p) * 2;
            return peri;
        }

        public string TotalPerimeter()
        { 
            int totalP = Perimeter(path1) + Perimeter(path2) + Perimeter(path3);
            string tPerimeter = totalP.ToString();
            return tPerimeter;
        }

        public void PerimeterWriter()
        {
            StreamWriter Pw = new StreamWriter(@"totalFencingPerimeter.txt");
            Pw.Write("The Total Perimeter is {0} feet", TotalPerimeter());
            Pw.Close();
        }
}
}
