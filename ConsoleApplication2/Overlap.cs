using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    public class Overlap: XYValues
    {
        public void OverLappigPlots()
        {
            int we = ValueW(path1) + ValueX(path1);
         

            if (ValueX(path2) >= ValueX(path1) && ValueX(path2) <= we)
            {
                string ValueNX = ValueX(path2).ToString();
                string ValueNY = ValueY(path2).ToString();
                string ValueNW = ValueW(path2).ToString();
                string ValueNH = ValueH(path2).ToString();
                StreamWriter SwOverLappiug = new StreamWriter(@"OverLappingPolts.txt");
                SwOverLappiug.Write("The Overlapping plot is : {0} ,{1}, {2} ,{3}", ValueNX, ValueNY, ValueNW, ValueNH);
                SwOverLappiug.Close();


            }
            else if (ValueX(path3) >= ValueX(path1) && ValueX(path3) <= we)
            {
                string ValueNX = ValueX(path3).ToString();
                string ValueNY = ValueY(path3).ToString();
                string ValueNW = ValueW(path3).ToString();
                string ValueNH = ValueH(path3).ToString();
                StreamWriter SwOverLappiug = new StreamWriter(@"OverLappingPolts.txt");
                SwOverLappiug.Write("The Overlapping plot is : {0} ,{1}, {2} ,{3}", ValueNX, ValueNY, ValueNW, ValueNH);
                SwOverLappiug.Close();

            }
            else
            {
                StreamWriter SwOverLappiug = new StreamWriter(@"OverLappingPolts.txt");
                SwOverLappiug.Write("No Plots are Overlapping");
                SwOverLappiug.Close();
            }

        }
    }
}


    

