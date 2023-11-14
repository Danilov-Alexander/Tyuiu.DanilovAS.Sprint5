using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            double y = (x) / (Math.Sqrt(Math.Pow(x, 2) + x));
            y = Math.Round(y, 3);

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}
