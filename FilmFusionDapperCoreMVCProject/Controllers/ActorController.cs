using Dapper;
using FilmFusionDapperCoreMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View(DapperModel.List<Actor>("ActorList"));
        }


        [HttpGet]
        public IActionResult AddActor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddActor(Actor newActor)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@FullName", newActor.FullName);
            prm.Add("@BirthDate", newActor.BirthDate);
            prm.Add("@ActorPhotoUrl", newActor.ActorPhotoUrl);
            DapperModel.Operations("InsertActor", prm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateActor(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@ActorId", id);
            return View(DapperModel.List<Actor>("GetActorWithId", prm).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult UpdateActor(Actor updatedActor)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@ActorId", updatedActor.ActorId);
            prm.Add("@FullName", updatedActor.FullName);
            prm.Add("@BirthDate", updatedActor.BirthDate);
            prm.Add("@ActorPhotoUrl", updatedActor.ActorPhotoUrl);
            DapperModel.Operations("UpdateActor", prm);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteActor(int id)
        {
            DynamicParameters prm = new DynamicParameters();
            prm.Add("@ActorId", id);
            DapperModel.Operations("DeleteActor", prm);
            return RedirectToAction("Index");
        }


    }
}
