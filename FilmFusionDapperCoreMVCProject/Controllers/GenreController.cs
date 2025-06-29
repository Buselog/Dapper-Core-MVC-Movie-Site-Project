using Dapper;
using FilmFusionDapperCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View(DapperModel.List<Genre>("GetGenreListByMovieCount"));
        }


        [HttpGet]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGenre(Genre newGenre)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@GenreName", newGenre.GenreName);
            DapperModel.Operations("InsertGenre", prm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGenre(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@GenreId", id);
            return View(DapperModel.List<Genre>("GetGenreWithId", prm).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult UpdateGenre(Genre updatedGenre)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@GenreId", updatedGenre.GenreId);
            prm.Add("@GenreName", updatedGenre.GenreName);
            DapperModel.Operations("UpdateGenre", prm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGenre(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@GenreId", id);
            DapperModel.Operations("DeleteGenre", prm);
            return RedirectToAction("Index");
        }




    }
}
