using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
