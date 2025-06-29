using Dapper;
using FilmFusionDapperCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace FilmFusionDapperCoreMVCProject.Controllers
{
    public class MovieActorController : Controller
    {
        public IActionResult Index()
        {
            //return View(DapperModel.List<MovieActor>("MovieActorListByMovieActor"));

            using (var db = new SqlConnection(DapperModel.connectionString))
            {
                var data = db.Query<MovieActor, Movie, Actor, MovieActor>(
                    "MovieActorListByMovieActor",
                    (movieActor, movie, actor) =>
                    {
                        movieActor.Movie = movie;
                        movieActor.Actor = actor;
                        return movieActor;
                    },
                    splitOn: "MovieId,ActorId",
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return View(data);
            }
        }


        [HttpGet]
        public IActionResult AddMovieActor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovieActor(MovieActor newMovieActor)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@Title", newMovieActor.Movie.Title);
            prm.Add("@FullName", newMovieActor.Actor.FullName);
            prm.Add("@CharacterName", newMovieActor.CharacterName);
            DapperModel.Operations("InsertMovieActor", prm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMovieActor(int id)
        {
            //DynamicParameters prm = new DynamicParameters();
            //prm.Add("@MovieActorId", id);
            //return View(DapperModel.List<MovieActor>("GetMovieActorWithId", prm).FirstOrDefault());

            using (var db = new SqlConnection(DapperModel.connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@MovieActorId", id);

                var data = db.Query<MovieActor, Movie, Actor,MovieActor>(
                    "GetMovieActorWithId",
                    (ma, movie, actor) =>
                    {
                        ma.Movie = movie;
                        ma.Actor = actor;
                        return ma;
                    },
                    parameters,
                    splitOn: "Title, FullName",
                    commandType: CommandType.StoredProcedure
                ).FirstOrDefault();

                ViewBag.Actors = DapperModel.List<Actor>("ActorList").ToList();
                ViewBag.Movies = DapperModel.List<Movie>("MovieList").ToList();

                return View(data);
            }

        }

        [HttpPost]
        public IActionResult UpdateMovieActor(MovieActor updatedMovieActor)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@MovieActorId", updatedMovieActor.MovieActorId);
            prm.Add("@MovieId", updatedMovieActor.Movie.MovieId);
            prm.Add("@ActorId", updatedMovieActor.Actor.ActorId);
            prm.Add("@CharacterName", updatedMovieActor.CharacterName);
            DapperModel.Operations("UpdateMovieActor", prm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMovieActor(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@MovieActorId", id);
            DapperModel.Operations("DeleteMovieActor", prm);
            return RedirectToAction("Index");
        }
    }
}
