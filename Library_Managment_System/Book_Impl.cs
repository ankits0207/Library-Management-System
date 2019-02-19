using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using Poco;
using System.Data;
namespace Library_Managment_System_Integrated
{
    class Book_Impl
    {
        DataSet ds;
        OracleDataAdapter sda;
        OracleCommand cmd;
        OracleConnection con = Connection.returnConnection();
        OracleDataReader reader;


        public List<Book> ReadBook(int? Bookid, string Publisher, string Category, string Subject)
        {
            List<Book> list_of_books = new List<Book>();

            ds = new DataSet();

            if (String.IsNullOrEmpty(Bookid.ToString()) == false)
            {
                cmd = new OracleCommand("select * from aaek_book where bid=" + Bookid, con);
                sda = new OracleDataAdapter(cmd);
                sda.Fill(ds, "Book");
            }

            else
            {
                //cmd = new OracleCommand("select * from aaek_book where publisher like '" + "%" + Publisher + "' or Category like '" + "%" + Category + "' or subject like '" + "%" + Subject + "'", con);
                cmd = new OracleCommand("select * from aaek_book where publisher like '" + Publisher + "%' and Category like '" + Category + "%'  and subject like '" + Subject + "%'", con);

                sda = new OracleDataAdapter(cmd);
                sda.Fill(ds, "Book");
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list_of_books.Add(new Book()
                {
                    Book_name = dr["BOOK_NAME"].ToString(),
                    Author = dr["AUTHOR"].ToString(),
                    Availability = Convert.ToChar(dr["AVAILABILITY"]),
                    BookId = Convert.ToInt32(dr["BID"]),
                    Publisher = dr["Publisher"].ToString(),
                    Category = dr["Category"].ToString(),
                    Subject = dr["Subject"].ToString(),
                    Mrp = Convert.ToInt32(dr["Mrp"]),
                    Count = Convert.ToInt32(dr["count"])
                });
            }


            return list_of_books;

        }


        public int GetMaxBookId()
        {
            string query = "select MAX(BID) from AAEK_Book";
            con.Open();
            cmd = new OracleCommand(query, con);
            reader = cmd.ExecuteReader();
            cmd = new OracleCommand(query, con);
            reader = cmd.ExecuteReader();
            int max = 0;
            object ob = cmd.ExecuteScalar();
            if (ob == null || ob == DBNull.Value)
            {
                max = 0;

            }
            else
            {
                max = Convert.ToInt32(ob);
            }
            con.Close();
            return max + 1;

        }

        public bool CreateBook(Book book)
        {
            int bookid = GetMaxBookId();
            book.BookId = bookid;
            OracleTransaction trans = null;
            try
            {
                con.Open();
                trans = con.BeginTransaction();
                string query = "insert into AAEK_book values(:bid,:bookname,:publisher,:author,:category,:subject,:mrp,:availability,:count)";
                cmd = new OracleCommand(query, con);
                cmd.Parameters.AddWithValue("bid", OracleType.Number).Value = book.BookId;
                cmd.Parameters.AddWithValue("bookname", OracleType.VarChar).Value = book.Book_name;
                cmd.Parameters.AddWithValue("publisher", OracleType.VarChar).Value = book.Publisher;
                cmd.Parameters.AddWithValue("author", OracleType.VarChar).Value = book.Author;
                cmd.Parameters.AddWithValue("category", OracleType.VarChar).Value = book.Category;
                cmd.Parameters.AddWithValue("subject", OracleType.VarChar).Value = book.Subject;
                cmd.Parameters.AddWithValue("mrp", OracleType.Number).Value = book.Mrp;
                cmd.Parameters.AddWithValue("availability", OracleType.VarChar).Value = book.Availability.ToString();
                cmd.Parameters.AddWithValue("count", OracleType.Number).Value = book.Count;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception e)
            {

                trans.Rollback();
                return false;
            }
            finally { con.Close(); }
        }
        public bool UpdateBook(Book book)
        {
            con.Open();
            OracleTransaction trans = con.BeginTransaction();
            try
            {
                cmd = new OracleCommand("update aaek_book set book_name='" + book.Book_name + "',publisher='" + book.Publisher + "',author='" + book.Author + "',category='" + book.Category + "',subject='" + book.Subject + "',mrp='" + book.Mrp + "',availability='" + book.Availability + "',count='" + book.Count + "' where bid ='" + book.BookId + "'", con, trans);
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception e)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}


