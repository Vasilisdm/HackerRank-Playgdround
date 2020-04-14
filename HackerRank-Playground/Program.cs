using System;
using System.Collections.Generic;
using HackerRank_Playground.Abstract;
using HackerRank_Playground.Inheritane;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            MyBook new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
