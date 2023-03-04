using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Book
    {
        public Book(string name, double price)

        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }

        public static List<Book> BuyABook(List<Book> bookGroup, string search)
        {
            //allows the user of your program to select from one to many books to purchase
            if (!bookGroup.Any(book => book.Name.Contains(search)))
            {
                Console.WriteLine("No book found");
                return new List<Book>();
            }
            else
            {
                var selected = from book in bookGroup
                    where book.Name.Contains(search)
                    select new Book(book.Name, book.Price)
                    {
                        Name = book.Name,
                        Price = book.Price
                    };
                return selected.ToList();
            }
        }

        public double CalcTotalPrice(List<Book> chosen)
        {
            //calculate the total amount of purchases
            double totalPrice = 0;
            foreach (var item in chosen)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
}
