using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    class MinimumFencing: XYValues
    {
        public int  MinimumFence(string a)
        {
            int MinF = ValueW(a) + ValueH(a);
            return MinF;
        }

        public  void  MFenceWriter()
        {
            int mFence = MinimumFence(path1) + MinimumFence(path2) + MinimumFence(path3);
            string mFence2 = mFence.ToString();
            StreamWriter mf = new StreamWriter(@"Minimunfencing.txt");
            mf.Write("The Minimum material need is {0} feets.", mFence2);
            mf.Close();
        }
          
    }
}
