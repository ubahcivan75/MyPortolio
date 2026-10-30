using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _Portfoli0ComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }
    }
}
