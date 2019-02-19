using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Poco;
using System.Data.OracleClient;

namespace Library_Managment_System_Integrated
{
    class TransactionImpl
    {
        BookTransaction btObj;
        OracleConnection con;
        OracleCommand cmd;
        OracleDataReader reader;
        string query;
        public int getNewTid()
        {
            OracleTransaction trans = null;
            try
            {

                con = Connection.returnConnection();
                con.Open();
                trans = con.BeginTransaction();
                query = "select MAX(TID) from AAEK_TRANSACTION";
                cmd = new OracleCommand(query, con);
                int val = 0;
                cmd.Transaction = trans;
                object ob = cmd.ExecuteScalar();
                trans.Commit();
                con.Close();
                if (ob == null || ob == DBNull.Value || Convert.ToInt32(ob) == 0)
                    val = 100;
                else
                    val = Convert.ToInt32(ob);
                return val + 1;
            }
            catch (Exception e)
            {
                trans.Rollback();
                con.Close();
                return 0;
            }
        }
        public int getNoBooks(int mid)
        {
            OracleTransaction trans = null;
            try
            {

                con = Connection.returnConnection();
                con.Open();
                trans = con.BeginTransaction();
                query = "select count(*) from AAEK_TRANSACTION where MID="+mid;
                cmd = new OracleCommand(query, con);
                int val = 0;
                cmd.Transaction = trans;
                object ob = cmd.ExecuteScalar();
                trans.Commit();
                con.Close();
                if (ob == null || ob == DBNull.Value || Convert.ToInt32(ob)==0)
                    val = 0;
                else
                    val = Convert.ToInt32(ob);
                return val;
                
            }
            catch (Exception e)
            {
                trans.Rollback();
                con.Close();
                return 0;
            }
        }
        public Boolean insert(BookTransaction btObj)
        {
            OracleTransaction trans = null;
            try
            {
                con.Open();
                trans = con.BeginTransaction();
                cmd = new OracleCommand("insert into AAEK_TRANSACTION(TID,MID,BID,ISSUE_DATE,IS_LOST) values(:Tid,:Mid,:Bid,:Issuedt,:Islost)", con);
                cmd.Parameters.AddWithValue("Tid", OracleType.Number).Value = btObj.TransactionId;
                cmd.Parameters.AddWithValue("Mid", OracleType.Number).Value = btObj.MemberId;
                cmd.Parameters.AddWithValue("Bid", OracleType.Number).Value = btObj.BookId;
                //cmd.Parameters.AddWithValue("Returndt", OracleType.VarChar).Value = btObj.ReturnDate;
                cmd.Parameters.AddWithValue("Issuedt", OracleType.VarChar).Value = btObj.IssueDate;
                cmd.Parameters.AddWithValue("Islost", OracleType.VarChar).Value = btObj.IsLost;
                cmd.Transaction = trans;
                int row = cmd.ExecuteNonQuery();
                trans.Commit();
                con.Close();
                if (row == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                
                trans.Rollback();
                con.Close();
                return false;
            }
        }
        public BookTransaction serach(int Tid)
        {
            OracleTransaction trans = null;
            try
            {
                con.Open();
                BookTransaction bt = new BookTransaction();
                trans = con.BeginTransaction();
                cmd = new OracleCommand("select * from AAEK_TRANSACTION where TID=:Tid", con);
                cmd.Parameters.AddWithValue("Tid", OracleType.Number).Value = btObj.TransactionId;
                cmd.Transaction = trans;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bt.TransactionId = reader.GetInt32(0);
                    bt.MemberId = reader.GetInt32(1);
                    bt.BookId = reader.GetInt32(2);
                    bt.IssueDate = Convert.ToDateTime(reader.GetString(3));
                    bt.ReturnDate = Convert.ToDateTime(reader.GetString(4));
                    bt.IsLost = reader.GetString(5);
                }
                trans.Commit();
                con.Close();
                return bt;
            }
            catch (Exception e)
            {
                
                trans.Rollback();
                con.Close();
                return null;
            }
        }
        public Boolean update(BookTransaction btObj)
        {
            OracleTransaction trans = null;
            try
            {
                con.Open();
                trans = con.BeginTransaction();
                cmd = new OracleCommand("update AAEK_TRANSACTION set RETURN_DATE=:Returndt,IS_LOST=:Islost where TID=:Tid", con);
                cmd.Parameters.AddWithValue("Tid", OracleType.Number).Value = btObj.TransactionId;
                cmd.Parameters.AddWithValue("Returndt", OracleType.VarChar).Value = btObj.ReturnDate;
                cmd.Parameters.AddWithValue("Islost", OracleType.Char).Value = btObj.IsLost;
                cmd.Transaction = trans;
                int row = cmd.ExecuteNonQuery();
                trans.Commit();
                con.Close();
                if (row == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
               
                trans.Rollback();
                con.Close();
                return false;
            }
        }
    }
}
