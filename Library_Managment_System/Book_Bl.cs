using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco;

namespace Library_Managment_System_Integrated
{
    class Book_Bl
    {

        public bool CreateBook(string bookname, string publisher, string author, string category, string subject, int mrp, char avail, int count)
        {
            Book book = new Book
            {
                Book_name = bookname,
                Publisher = publisher,
                Author = author,
                Category = category,
                Subject = subject,
                Mrp = mrp,
                Availability = avail,
                Count = count
            };

            return new Book_Impl().CreateBook(book);
        }

        public List<Book> SearchBook(int? bid, string category, string subject, string publisher)
        {

            return new Book_Impl().ReadBook(bid, publisher, category, subject);

        }
    }
}


