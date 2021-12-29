using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models
{
    public class Grid : IGrid
    {
        public IList<IShape> Shapes { get; set; }
    }
}
