using System;

namespace Class
{


    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("J.K Rowling", "Harry Potter", 365, 2008);
            Book book2 = new Book("Dan Brown", "DaVinci Code", 423, 2003);

            Console.WriteLine(book1.author);
        }
    }
}