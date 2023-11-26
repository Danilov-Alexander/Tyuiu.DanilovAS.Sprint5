using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DanilovAS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            int res = 1;
            string[] strNumbs = File.ReadAllLines(path);
            int temp = int.MinValue;
            foreach (string number in strNumbs)

                if (!number.Contains(',') && int.Parse(number) % 2 == 0 && int.Parse(number) > temp)
                {
                    temp = int.Parse(number);
                }

            for (int i = 1; i <= temp; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}
