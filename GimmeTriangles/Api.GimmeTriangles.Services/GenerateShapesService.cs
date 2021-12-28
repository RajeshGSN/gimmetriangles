using Api.GimmeTriangles.Models;
using Api.GimmeTriangles.Models.Interfaces;
using Api.GimmeTriangles.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Services
{
    public class GenerateShapesService : IGenerateShapesService
    {
        public IList<IShape> GenerateShapes(int rows, int columns, int cellSize)
        {
            IList<IShape> triangles = new List<IShape>();
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    IShape leftBottomTriangle = GetLeftBottomTriangle(i, j);
                    IShape rightTopTrinagle = GetRightTopTriangle(i, j);
                    triangles.Add(leftBottomTriangle);
                    triangles.Add(rightTopTrinagle);
                }
            }
            return triangles;
        }

        private IShape GetLeftBottomTriangle(int rowIndex, int colIndex)
        {
            IShape leftBottomTriangle = new Triangle
            {
                cellName = Convert.ToChar(64 + rowIndex) + ""+ Convert.ToString(2*colIndex-1),
                coordinates = new List<ICoordinates>
            {
                new Coordinates { x = rowIndex, y = colIndex },
                new Coordinates { x = rowIndex + 1, y = colIndex },
                new Coordinates { x = rowIndex + 1, y = colIndex + 1 }
            }
            };
            return leftBottomTriangle;
        }

        private IShape GetRightTopTriangle(int rowIndex, int colIndex)
        {
            IShape rightTopTriangle = new Triangle
            {
                cellName = Convert.ToChar(64 + rowIndex) + ""+ Convert.ToString(2 * colIndex),
                coordinates = new List<ICoordinates>
            {
                new Coordinates { x = rowIndex, y = colIndex },
                new Coordinates { x = rowIndex , y = colIndex + 1 },
                new Coordinates { x = rowIndex + 1, y = colIndex + 1 }
            }
            };
            return rightTopTriangle;
        }
    }
}
