using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models
{
    public class CellDetails : ICellDetails
    {
        public int row { get; set ; }
        public int column { get; set; }
    }
}
