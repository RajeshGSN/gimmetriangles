using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Api.GimmeTriangles.Models.Interfaces;

namespace Api.GimmeTriangles.Models
{
    public class Coordinates : ICoordinates
    {
        public int x { get; set; }
        public int y { get; set; }

        public bool Equals([AllowNull] ICoordinates tobeChecked)
        {
            return tobeChecked.x == x && tobeChecked.y == y;
        }
    }
}
