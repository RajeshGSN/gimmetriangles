using Api.GimmeTriangles.Models;
using Api.GimmeTriangles.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Services.Test
{
    [TestClass]
    public class CellDetailsServiceTest
    {
        [TestMethod]
        public void GetCellDetailsFromGridTest()
        {
            //Arrange
            var cellDetailsService = new CellDetailsService();

            var mockCoordinates = new List<ICoordinates>();
            mockCoordinates.Add(new Coordinates { x = 1, y = 1 });
            mockCoordinates.Add(new Coordinates { x = 1, y = 2 });
            mockCoordinates.Add(new Coordinates { x = 2, y = 1 });

            var mockTriangles = new List<IShape>();
            mockTriangles.Add(new Triangle { cellName = "A1", coordinates = mockCoordinates });

            var mockGrid = new Grid { Shapes = mockTriangles };
            //Act
            ICellDetails cellDetails = cellDetailsService.GetCellDetailsFromGrid(mockGrid, mockCoordinates.ToArray());

            //Assert
            Assert.AreEqual(cellDetails.row, 1);
            Assert.AreEqual(cellDetails.column, 1);

        }

    }
}
