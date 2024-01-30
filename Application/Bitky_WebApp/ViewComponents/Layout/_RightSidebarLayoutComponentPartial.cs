using System;
using Microsoft.AspNetCore.Mvc;

namespace Bitky_WebApp.ViewComponents.Layout
{
	public class _RightSidebarLayoutComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

