using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Services.Interfaces
{
    public interface IGenerateShapesService
    {
        IList<IShape> GenerateShapes(int rows,int columns, int cellSize);
    }
}
