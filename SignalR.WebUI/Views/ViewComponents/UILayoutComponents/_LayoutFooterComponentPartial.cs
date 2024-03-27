using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Views.ViewComponents.UILayoutComponents
{
	public class _LayoutFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
