﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenRental
{
    public class XYValues
    {
        public string path1 = @"Plot1.txt";
        public string path2 = @"Plot2.txt";
        public string path3 = @"Plot3.txt";

        public void Plots()
        {
            string gardenplot1 = ("2, 2, 10, 20");
            string gardenplot2 = ("100, 10, 5, 5");
            string gardenplot3 = ("5, 5, 10, 10");

            StreamWriter sw = new StreamWriter(path1);
            sw.Write(gardenplot1);
            sw.Close();
            StreamWriter sw2 = new StreamWriter(path2);
            sw2.Write(gardenplot2);
            sw2.Close();
            StreamWriter sw3 = new StreamWriter(path3);
            sw3.Write(gardenplot3);
            sw3.Close();

        }

        public int ValueX(string a)
        {
            StreamReader sr1 = new StreamReader(a);
            string PositionX = sr1.ReadToEnd();
            int X1Value = int.Parse(PositionX.Split(',')[0]);
            return X1Value;
        }
        public int ValueY(string a)
        {
            StreamReader sr2 = new StreamReader(a);
            string PositionY = sr2.ReadToEnd();
            int Y1Value = int.Parse(PositionY.Split(',')[1]);
            return Y1Value;
        }
        public int ValueW(string a)
        {
            StreamReader sr3 = new StreamReader(a);
            string PositionW = sr3.ReadToEnd();
            int W1Value = int.Parse(PositionW.Split(',')[2]);
            return W1Value;
        }

        public int ValueH(string a)
        {
            StreamReader sr4 = new StreamReader(a);
            string PositionH = sr4.ReadToEnd();
            int H1Value = int.Parse(PositionH.Split(',')[3]);
            sr4.Close();
            return H1Value;
        }
    }
}
