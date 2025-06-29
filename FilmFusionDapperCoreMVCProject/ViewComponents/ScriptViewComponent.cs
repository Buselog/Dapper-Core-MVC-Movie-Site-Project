using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.ViewComponents
{
    public class ScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
