using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poco
{
    public class Book
    {
        public int BookId { get; set; }
        public string Book_name
        {
            get;
            set;
        }
        public string Publisher {
            get;
            set; 
        }
        public string Author
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public int Mrp
        {
            get;
            set;
        }
        
        public char Availability
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }



    }
}