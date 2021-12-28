using Api.GimmeTriangles.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Api.GimmeTriangles.Models.Interfaces;
using Api.GimmeTriangles.Models;

namespace Api.GimmeTriangles
{
    [Route("[controller]")]
    [ApiController]
    public class TrianglesController : Controller
    {
        private readonly IGenerateShapesService _generateShapesService;

        public TrianglesController(IGenerateShapesService generateShapesService)
        {
            _generateShapesService = generateShapesService;
        }
        [HttpGet]
        public string test()
        {
            return "OK";
        }

        [HttpGet]
        [Route("coordinates")]
        public JsonResult GetTriangles([FromBody] GridProperties request)
        {
            IList<IShape> triangles = _generateShapesService.GenerateShapes(request.rows, request.columns, request.CellSize);
            return Json(triangles);
        }

        [HttpGet]
        [Route("getcelldetails")]
        public string GetCellDetails([FromBody] GridDetailsByVertices request)
        {
            IList<IShape> triangles = _generateShapesService.GenerateShapes(request.gridProperties.rows, request.gridProperties.columns, request.gridProperties.CellSize);
            var check = triangles[0].coordinates[0].Equals(request.verticies[0]);
            List<ICoordinates> verticis = request.verticies.ToList().ToList<ICoordinates>();
            var cellName = triangles.AsEnumerable<IShape>().Where(t => t.coordinates.SequenceEqual(verticis)).FirstOrDefault().cellName;
            return cellName;
        }
    }
}
