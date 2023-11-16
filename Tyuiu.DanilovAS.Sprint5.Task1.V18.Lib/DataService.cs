using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            for ( int x = startValue; x <= stopValue; x += 1)
            {
                double result = 3*x + 2 - (2*x-x)/(Math.Cos(x)+1);

                if(double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                string strResult = Convert.ToString(result);
               
                if (x != stopValue)
                {
                    File.AppendAllText(path, strResult + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strResult);
                }


            }

            

            return path;
        }
    }
}
