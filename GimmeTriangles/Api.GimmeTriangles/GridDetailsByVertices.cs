using Api.GimmeTriangles.Models;
using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GimmeTriangles
{
    public class GridDetailsByVertices
    {
        public GridProperties gridProperties { get; set; }
        public Coordinates[] verticies { get; set; }
    }
}
