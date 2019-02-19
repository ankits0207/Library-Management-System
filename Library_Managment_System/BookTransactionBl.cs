using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco;
namespace Library_Managment_System_Integrated
{
    class BookTransactionBl
    {
        TransactionImpl transob;
        public String IssueBook(int bid, int mid)
        {
            BookTransaction ob=new BookTransaction();
            transob = new TransactionImpl();
            int noOfBooks=transob.getNoBooks(mid);
            if (noOfBooks < 2)
            {
                int tid = transob.getNewTid();
                ob.TransactionId = tid;
                ob.MemberId = mid;
                ob.BookId = bid;
                ob.IssueDate = DateTime.Today;
                ob.IsLost = "N";
                bool status = transob.insert(ob);
                if (status)
                    return "Success";
                else
                    return "Try Again !!";
            }
            else
            {
                return "Max Limit Reached";
            }
        }
    }
}
