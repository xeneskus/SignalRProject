using Microsoft.AspNetCore.Mvc;

namespace SignalR.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
