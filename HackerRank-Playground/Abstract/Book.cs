using System;
namespace HackerRank_Playground.Abstract
{
    public abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
}
