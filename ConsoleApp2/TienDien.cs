using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TienDien
    {
        //input 
        public double N;
        //output
        public double tiendien { get;private set; }
        public double TinhTienDien()
        {
            const int SO_BAC = 6;

            int[] nguong = { 0, 50, 100, 200, 300, 400 };

            double[] gia = { 1806, 1866, 2167, 2729, 3050, 3151 };
            tiendien = 0;


            for (int i = SO_BAC - 1; i >= 0; i--)
            {
                if (N > nguong[i])
                {
                    tiendien += (N - nguong[i]) * gia[i];
                    N = nguong[i];
                }
            }

            return tiendien;
        }
    }
}
