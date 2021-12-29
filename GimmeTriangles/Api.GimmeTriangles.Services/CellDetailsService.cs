using Api.GimmeTriangles.Models;
using Api.GimmeTriangles.Models.Interfaces;
using Api.GimmeTriangles.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.GimmeTriangles.Services
{
    public class CellDetailsService : ICellDetailsService
    {
        public ICellDetails GetCellDetailsFromGrid(IGrid grid, ICoordinates[] verticies)
        {
            string cellName = grid.Shapes.AsEnumerable<IShape>().Where(t => t.coordinates.SequenceEqual(verticies)).FirstOrDefault().cellName;
            return GetCellDetailsFromCellName(cellName);
        }

        private ICellDetails GetCellDetailsFromCellName(string cellName)
        {
            char rowValue = cellName[0];
            char columnValue = cellName[1];
            int rowNumber = Convert.ToInt32(rowValue) - 64;
            int columnNumber = (int)Char.GetNumericValue(columnValue);
            return new CellDetails { row = rowNumber, column = columnNumber };
        }
    }
}
