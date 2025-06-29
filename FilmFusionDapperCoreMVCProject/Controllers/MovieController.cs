using Dapper;
using FilmFusionDapperCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Data;
using System.Data.SqlClient;

namespace FilmFusionDapperCoreMVCProject.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

           // Map ve splitOn, veri çekildiği zaman yani SELECT sorgularında kullan.INSERT, UPDATE, DELETE gibi işlemlerde gerek yok.

            using (SqlConnection db = new SqlConnection(DapperModel.connectionString))
            {
                db.Open();
                var  movieList = db.Query<Movie, Genre, Movie>(
                    "MovieListByGenre",                    // procedure adı
                    (movie, genre) =>
                    {
                        movie.Genre = genre;              // Genre nesnesini Movie nesnesine bağla
                        return movie;
                    },
                    splitOn: "GenreId",                 // GenreName alanından itibaren ayır
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return View(movieList);
            }

          
        }


        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.GenreList = DapperModel.List<Genre>("GenreList").ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@Title", newMovie.Title);
            prm.Add("@ReleaseYear", newMovie.ReleaseYear);
            prm.Add("@GenreId", newMovie.GenreId);
            prm.Add("@Description", newMovie.Description);
            prm.Add("@PosterUrl", newMovie.PosterUrl);
            prm.Add("@TrailerUrl", newMovie.TrailerUrl);
            DapperModel.Operations("InsertMovie", prm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMovie(int id)
        {
            //DynamicParameters prm = new DynamicParameters();
            //prm.Add("@MovieId", id);
            //return View(DapperModel.List<Movie>("GetMovieWithId", prm).FirstOrDefault());

            using (var db = new SqlConnection(DapperModel.connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@MovieId", id);

                var data = db.Query<Movie, Genre, Movie>(
                    "GetMovieWithId",
                    (movie, genre) =>
                    {
                        movie.Genre = genre; // movie nesnesinin Genre'sini set et
                        return movie;
                    },
                    parameters,
                    splitOn: "GenreId", // GenreId üzerinden ayır
                    commandType: CommandType.StoredProcedure
                ).FirstOrDefault();

                // Dropdown için tüm türleri ViewBag'e ata
                ViewBag.Genres = DapperModel.List<Genre>("GetGenreListByMovieCount").ToList();

                return View(data);
            }
        }
        [HttpPost]
           public IActionResult UpdateMovie(Movie updatedMovie)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@MovieId", updatedMovie.MovieId);
            prm.Add("@Title", updatedMovie.Title);
            prm.Add("@ReleaseYear", updatedMovie.ReleaseYear);
            prm.Add("@GenreId", updatedMovie.Genre.GenreId);
            prm.Add("@Description", updatedMovie.Description);
            prm.Add("@PosterUrl", updatedMovie.PosterUrl);
            prm.Add("@TrailerUrl", updatedMovie.TrailerUrl);
            DapperModel.Operations("UpdateMovie", prm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMovie(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@MovieId", id);
            DapperModel.Operations("DeleteMovie", prm);
            return RedirectToAction("Index");
        }
    }
}
