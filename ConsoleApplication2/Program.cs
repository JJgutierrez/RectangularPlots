using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    class Program: XYValues
    {
       
        static void Main()
        {
            
            Overlap op = new Overlap();
            op.Plots();
            op.OverLappigPlots();
            FencingPerimeter fp = new FencingPerimeter();
            fp.PerimeterWriter();
            MinimumFencing mn = new MinimumFencing();
            mn.MFenceWriter();
            Fertilizer fr = new Fertilizer();
            fr.TotalFertilizer();
            RoateWriter rt = new RoateWriter();
            rt.writer();
          



        }
    }
}
