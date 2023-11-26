using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < line.Length - 3; i++)
                    {
                        if (!char.IsDigit(line[i - 1]) && char.IsDigit(line[i]) && char.IsDigit(line[i + 1]) && char.IsDigit(line[i + 2]) && !char.IsDigit(line[i + 3]))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
