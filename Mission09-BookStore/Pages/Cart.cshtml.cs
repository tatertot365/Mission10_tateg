using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_BookStore.Infrastructure;
using Mission09_BookStore.Models;

namespace Mission09_BookStore.Pages
{
	public class CartModel : PageModel
    {
        private BookstoreBooksRepository repo { get; set; }
        public CartModel (BookstoreBooksRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookid, string returnUrl)
        {
            Books b = repo.Books.FirstOrDefault(x => x.BookId == bookid);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();

            basket.AddItem(b, 1);

            HttpContext.Session.SetJSON("basket", basket);

            return RedirectToPage(new {ReturnUrl = returnUrl});

        }
    }
}
