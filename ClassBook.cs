using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Book
    {
        string author = "";
        string bookName = "";
        int numberOfPages = 0;
        int yearOfPublish = 0;

        public Book(string author, string bookName, int numberOfPages, int yearOfPublish)
        {
            this.author = author;
            this.bookName = bookName;
            this.numberOfPages = numberOfPages;
            this.yearOfPublish = yearOfPublish;
        }
    }
}

