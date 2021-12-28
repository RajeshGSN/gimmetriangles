using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models.Interfaces
{
    public interface IShape
    {
        IList<ICoordinates> coordinates { get; set; }
        string cellName { get; set; }
    }
}
