using Microsoft.AspNetCore.Mvc;

namespace FilmFusionDapperCoreMVCProject.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
