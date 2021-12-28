using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Services.Test
{
    [TestClass]
    public class GenerateShapesServiceTest
    {
        [TestMethod]
        public void GenerateShapesTest()
        {
            int rows = 6;
            int columns = 6;
            int cellSize = 1;
            var service = new GenerateShapesService();
            var triangles = service.GenerateShapes(rows, columns, cellSize);
            Assert.AreEqual(triangles.Count, 72);
        }
    }
}
