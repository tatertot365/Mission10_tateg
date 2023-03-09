using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission09_BookStore.Models
{
	public class Basket
	{
		public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

		public void AddItem(Books b, int qty)
		{
			BasketLineItem line = Items
				.Where(x => x.Book.BookId == b.BookId)
				.FirstOrDefault();

			if (line == null)
			{
				Items.Add(new BasketLineItem
				{
					Book = b,
					Quantity = qty
				});
			}
			else
			{
				line.Quantity += qty;
			}
		}

        public double CalculateTotal()
        {
			double sum = Items.Sum(x => x.Quantity * x.Book.Price);

			return sum;
        }

    }


    public class BasketLineItem
	{
		public int LineID { get; set; }
		public Books Book { get; set; }
		public int Quantity { get; set; }
	}
}

