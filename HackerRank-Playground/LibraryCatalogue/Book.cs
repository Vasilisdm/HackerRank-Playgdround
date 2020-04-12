using System;
namespace HackerRank_Playground
{
    public class Book
    {
        private string _title;
        private int _pageCount;
        private int _isbn;
        private bool _isCheckedOut;
        private int _daysCheckedOut;

        public Book(string bookTitle, int bookPageCount, int bookISBN)
        {
            _title = bookTitle;
            _pageCount = bookPageCount;
            _isbn = bookISBN;
            _isCheckedOut = false;
        }

        public string Title { get; private set; }
        public int PageCount { get; private set; }
        public int ISBN { get; private set; }
        public bool IsCheckedOut { get; set; }
        public int DaysCheckedOut { get; private set; } = -1;
    }
}
