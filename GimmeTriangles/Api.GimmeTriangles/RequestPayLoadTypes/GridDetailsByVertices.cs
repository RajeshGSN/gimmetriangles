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
        public GridProperties GridProperties { get; set; }
        public Coordinates[] Verticies { get; set; }
    }
}
