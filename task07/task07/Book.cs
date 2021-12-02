using System;

namespace Book
{
    class Book : IComparable
    {
        public string author { get; private set; }
        public string title { get; private set; }
        public int year { get; private set; }
        public int pages { get; private set; }

        public void SetBook(string author, string title, int year, int pages)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.pages = pages;
        }

        public void Show()
        {
            Console.WriteLine("\nBook:\n Author: {0}\n Title: {1}\n Year: {2}\n {3} pages.\n", author, title, year, pages);
        }

        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
    }
}