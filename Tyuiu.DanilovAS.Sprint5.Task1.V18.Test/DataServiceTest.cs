using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint5.Task1.V18.Lib;
using System.IO;


namespace Tyuiu.DanilovAS.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.DanilovAS.Sprint5\Tyuiu.DanilovAS.Sprint5.Task1.V18\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}
