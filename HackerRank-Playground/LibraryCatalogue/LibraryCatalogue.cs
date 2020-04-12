using System;
using System.Collections.Generic;

namespace HackerRank_Playground
{
    public class LibraryCatalogue
    {
        Dictionary<string, Book> _bookCollection = new Dictionary<string, Book>();
        private int _currentDay = 0;
        private int _lengthOfCheckedOutPeriod = 7;
        private double _initialLateFee = 0.50;
        private double _feePerLateDay = 1.00;

        public LibraryCatalogue(Dictionary<string, Book> collection)
        {
            _bookCollection = collection;
        }

        public LibraryCatalogue(Dictionary<string, Book> collection, int lengthOfCheckedOutPeriod,
            double initialLateFee, double feePerLateDay)
        {
            _bookCollection = collection;
            _lengthOfCheckedOutPeriod = lengthOfCheckedOutPeriod;
            _initialLateFee = initialLateFee;
            _feePerLateDay = feePerLateDay;
        }

        public Dictionary<string, Book> GetBookCollection{ get => _bookCollection; }
        public Book GetBook(string bookTitle) { return GetBookCollection[bookTitle]; }
        public int GetCurrentDay { get => _currentDay; }
        public int GetLengthOfCheckedOutPeriod { get => _lengthOfCheckedOutPeriod; }
        public double GetInitialLateFee { get => _initialLateFee; }
        public double GetFeePerLateday { get => _feePerLateDay; }

        public void NextDay()
        {
            _currentDay++;
        }

        public void checkOutBook(int day)
        {
            _currentDay = day;
        }

        public void CheckOutbook(string title)
        {
            Book book = GetBook(title);
            if (book.IsCheckedOut)
            {
                BookAlreadyCheckedOut(book);
            }
            else
            {
                book.IsCheckedOut = true;
                Console.WriteLine($"You just checked out {book.Title}");
            }
        }

        public void ReturnBook(string title)
        {
            Book book = GetBook(title);
            int daysLate = _currentDay - (book.DaysCheckedOut) + GetLengthOfCheckedOutPeriod;
            if (daysLate > 0)
            {
                Console.WriteLine($"You owe: {GetInitialLateFee + daysLate * GetFeePerLateday}");
            }
        }

        public void BookAlreadyCheckedOut(Book book)
        {
            Console.WriteLine($"Sorry {book.Title} is already checked out.");
        }
    }
}
