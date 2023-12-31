﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint5.Task5.V21.Lib;
using System.IO;

namespace Tyuiu.DanilovAS.Sprint5.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationTest()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            DataService service = new DataService();
            Assert.AreEqual(720, service.LoadFromDataFile(path));

        }


        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait,fileExists);
        }
    }
}
