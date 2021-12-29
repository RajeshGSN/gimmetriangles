using System;
using System.Collections.Generic;
using System.Text;

namespace Api.GimmeTriangles.Models.Interfaces
{
    public interface IGrid
    {
        public IList<IShape> Shapes { get; set; }

    }
}
