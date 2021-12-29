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
        private readonly ICellDetailsService _cellDetailsService;

        public TrianglesController(IGenerateShapesService generateShapesService, ICellDetailsService cellDetailsService)
        {
            _generateShapesService = generateShapesService;
            _cellDetailsService = cellDetailsService;
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
            IGrid triangles = _generateShapesService.GenerateShapes(request.rows, request.columns, request.CellSize);
            return Json(triangles);
        }

        [HttpGet]
        [Route("celldetails")]
        public JsonResult GetCellDetails([FromBody] GridDetailsByVertices request)
        {
            IGrid grid = _generateShapesService.GenerateShapes(request.GridProperties.rows, request.GridProperties.columns, request.GridProperties.CellSize);
            List<ICoordinates> verticis = request.Verticies.ToList().ToList<ICoordinates>();
            var cellName = _cellDetailsService.GetCellDetailsFromGrid(grid, request.Verticies);
            return Json(cellName);
        }
    }
}
