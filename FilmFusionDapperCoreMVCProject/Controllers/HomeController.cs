using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using FilmFusionDapperCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;

namespace FilmFusionDapperCoreMVCProject.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly IDbConnection _db;

        public HomeController(IConfiguration config)
        {
            _db = new SqlConnection(config.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {

            var movies = _db.Query<Movie>("GetLast10Movies", commandType: CommandType.StoredProcedure).ToList();

            ViewBag.MovieCount = _db.ExecuteScalar<int>("MovieCount", commandType: CommandType.StoredProcedure);
            ViewBag.ActorCount = _db.ExecuteScalar<int>("ActorCount", commandType: CommandType.StoredProcedure);
            ViewBag.GenreCount = _db.ExecuteScalar<int>("GenreCount", commandType: CommandType.StoredProcedure);

            ViewBag.MoviePosters = _db.Query<Movie>("MoviePosters", commandType: CommandType.StoredProcedure);

            ViewBag.Actors = DapperModel.List<Actor>("ActorListForAge");

            return View(movies);
        }
    }
}
