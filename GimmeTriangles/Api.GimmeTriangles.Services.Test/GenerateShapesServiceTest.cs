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
        public void GenerateShapesTest_With6RowsAnd12Columns()
        {
            int rows = 6;
            int columns = 12;
            int cellSize = 1;
            var service = new GenerateShapesService();
            var triangles = service.GenerateShapes(rows, columns, cellSize);
            Assert.AreEqual(triangles.Shapes.Count, 72);
        }
    }
}
