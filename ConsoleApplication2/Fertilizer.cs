using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    class Fertilizer:Overlap
    {
        public int FertilizerArea(string b)
        {
            int plotArea = ValueW(b) * ValueH(b);
            return plotArea;
        }

        public void TotalFertilizer ()
        {
            int totalAreaOverLap = ((ValueX(path1) - (ValueX(path3)) * ValueH(path3)));
            //Find the total amount of fertilizer necessary to cover all of the garden plots, given that it takes half a bottle to fertilize a square foot of garden. (the overlapping portion of overlapping plots shouldn't be counted twice)
            int totalAreaFertilizer =( FertilizerArea(path1) + FertilizerArea(path2) + FertilizerArea(path3) - totalAreaOverLap) /2;
            string taf = totalAreaFertilizer.ToString();
            StreamWriter mf = new StreamWriter(@"TotalFertilizaer.txt");
            mf.Write("The amount of Fertilizer that you need is {0} Bottles.", taf);
            mf.Close();



        }
    }
}
