using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission09_BookStore.Models;

namespace Mission09_BookStore.Components
{
	public class CategoriesViewComponent : ViewComponent
	{
		private BookstoreBooksRepository repo { get; set; }

		public CategoriesViewComponent (BookstoreBooksRepository temp)
		{
			repo = temp;
		}

		public IViewComponentResult Invoke()
		{
			ViewBag.SelectedCategory = RouteData?.Values["Category"];

			var categories = repo.Books
				.Select(x => x.Category)
				.Distinct()
				.OrderBy(x => x);

			return View(categories);
		}

	}
}

