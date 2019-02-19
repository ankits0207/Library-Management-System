using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poco
{
    class BookTransaction
    {
        public int TransactionId
        {
            get;
            set;
        }

        public int MemberId
        {
            get;
            set;
        }
        public int BookId
        {
            get;
            set;
        }
        public DateTime IssueDate
        {
            get;
            set;
        }
        public DateTime ReturnDate
        {
            get;
            set;
        }
        public string IsLost
        {
            get;
            set;
        }

    }
}
