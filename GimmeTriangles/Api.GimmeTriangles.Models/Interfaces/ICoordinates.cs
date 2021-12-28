using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models.Interfaces
{
    public interface ICoordinates: IEquatable<ICoordinates>
    {
        int x { get; set; }
        int y { get; set; }
    }
}
