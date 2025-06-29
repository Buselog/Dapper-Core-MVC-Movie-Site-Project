using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.ViewComponents
{
    public class HeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
