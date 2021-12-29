using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Services.Interfaces
{
    public interface ICellDetailsService
    {
        public ICellDetails GetCellDetailsFromGrid(IGrid grid, ICoordinates[] verticies);
    }
}
