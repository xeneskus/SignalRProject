using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Views.ViewComponents.UILayoutComponents
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
