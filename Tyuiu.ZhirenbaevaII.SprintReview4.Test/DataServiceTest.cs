﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.SprintReview4.Lib;

namespace Tyuiu.ZhirenbaevaII.SprintReview4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5; int columns = 3;
            int[,] mtrx = new int[rows, columns]; string str = "145258749635789";
            DataService ds = new DataService(); int res = ds.Calculate(rows, columns, str);
            int wait = 12288; Assert.AreEqual(wait, res);
        }
    }
}
