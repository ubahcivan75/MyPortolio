using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
    public class _layoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
