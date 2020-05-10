using System;
namespace HackerRank_Playground.Abstract
{
    public class MyBook : Book
    {
        private int _price;

        public MyBook(string title, string author, int price) : base (title, author)
        {
            _price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {_price}");
        }
    }
}
