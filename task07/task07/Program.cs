using System;

namespace Book
{
    public class Program
    {
        public static void Main()
        {
            Book book1 = new Book();
            book1.SetBook("Author1", "Title1", 1949, 100);

            Book book2 = new Book();
            book2.SetBook("Author2", "Title2", 1936, 50);

            Book book3 = new Book();
            book3.SetBook("Author3", "Title3", 1988, 200);

            Book book4 = new Book();
            book4.SetBook("Author4", "Title4", 1988, 150);

            Book book5 = new Book();
            book5.SetBook("Author5", "Title5", 1998, 100);

            Book[] arrayBooks = new Book[] { book1, book2, book3, book4, book5 };

            Array.Sort(arrayBooks);

            foreach (var book in arrayBooks)
            {
                book.Show();
            }
        }
    }
}

