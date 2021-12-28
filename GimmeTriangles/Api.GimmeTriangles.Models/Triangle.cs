using Api.GimmeTriangles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models
{
    public class Triangle : IShape
    {
        public IList<ICoordinates> coordinates { get; set; }
        public string cellName {get; set;}
    }
}
