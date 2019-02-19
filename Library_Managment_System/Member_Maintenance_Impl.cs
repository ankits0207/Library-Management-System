using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using Poco;
using System.Data;

namespace Library_Managment_System_Integrated
{
    class Member_Maintenance_Impl
    {
        OracleConnection con = Connection.returnConnection();
        OracleCommand cmd;
        OracleDataAdapter oda;
        DataSet ds;

        public List<Member> Read_Member(int mid, String name)
        {
            con.Open();
            OracleTransaction trans = con.BeginTransaction();
            try
            {
                Member m = new Member();
                List<Member> memlist = new List<Member>();
                if (mid == 0)
                {
                    cmd = new OracleCommand("select * from aaek_member where member_name like '" + name + "%'", con);
                    //cmd.Parameters.AddWithValue("memname", OracleType.VarChar).Value = name;
                    cmd.Transaction = trans;
                    oda = new OracleDataAdapter(cmd);
                    ds = new DataSet();
                    oda.Fill(ds, "AAEK_MEMBER");

                }
                else
                {

                    cmd = new OracleCommand("select * from AAEK_MEMBER where MID = :memid", con);
                    cmd.Parameters.AddWithValue("memid", OracleType.Number).Value = mid;
                    cmd.Transaction = trans;
                    oda = new OracleDataAdapter(cmd);
                    ds = new DataSet();
                    oda.Fill(ds, "AAEK_MEMBER");

                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    memlist.Add(new Member { MemberId = Convert.ToInt32(dr["MID"]), MemberName = Convert.ToString(dr["MEMBER_NAME"]), Course = Convert.ToString(dr["COURSE"]), Address = Convert.ToString(dr["ADDRESS"]), Status = Convert.ToString(dr["STATUS"]), ContactNo = Convert.ToString(dr["CONTACT_NO"]) });

                }
                trans.Commit();

                return memlist;
            }
            catch (Exception e)
            {
                trans.Rollback();
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Create_Member(Member m)
        {
            con.Open();
            OracleTransaction trans = con.BeginTransaction();
            try
            {
                cmd = new OracleCommand("insert into AAEK_MEMBER values(:mid,:memname,:course,:address,:status,:contactno)", con);
                cmd.Transaction = trans;
                cmd.Parameters.AddWithValue("mid", OracleType.Number).Value = m.MemberId;
                cmd.Parameters.AddWithValue("memname", OracleType.VarChar).Value = m.MemberName;
                cmd.Parameters.AddWithValue("course", OracleType.VarChar).Value = m.Course;
                cmd.Parameters.AddWithValue("address", OracleType.VarChar).Value = m.Address;
                cmd.Parameters.AddWithValue("status", OracleType.VarChar).Value = m.Status;
                cmd.Parameters.AddWithValue("contactno", OracleType.VarChar).Value = m.ContactNo;
                oda.InsertCommand = cmd;
                oda.InsertCommand.ExecuteNonQuery();
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

        public bool Update_Member(Member m)
        {
            con.Open();
            OracleTransaction trans = con.BeginTransaction();
            try
            {
                cmd = new OracleCommand("update AAEK_MEMBER set MEMBER_NAME=:memname,COURSE=:course,ADDRESS=:address,STATUS=:status,CONTACT_NO=:contactno where MID =:mid)", con);
                cmd.Parameters.AddWithValue("mid", OracleType.Number).Value = m.MemberId;
                cmd.Parameters.AddWithValue("memname", OracleType.VarChar).Value = m.MemberName;
                cmd.Parameters.AddWithValue("course", OracleType.VarChar).Value = m.Course;
                cmd.Parameters.AddWithValue("address", OracleType.VarChar).Value = m.Address;
                cmd.Parameters.AddWithValue("status", OracleType.VarChar).Value = m.Status;
                cmd.Parameters.AddWithValue("contactno", OracleType.VarChar).Value = m.ContactNo;
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

        public int Get_New_Mid()
        {
            con.Open();
            OracleTransaction trans = con.BeginTransaction();
            try
            {
                cmd = new OracleCommand("select MAX(MID) from AAEK_MEMBER)", con);
                cmd.Transaction = trans;
                int i = 100;
                object val = cmd.ExecuteScalar();
                if (val == null || val == DBNull.Value)
                    i = 100;
                else
                    i = (int)val;

                trans.Commit();
                return i + 1;
            }
            catch (Exception e)
            {
                trans.Rollback();
                return 0;
            }
            finally
            {
                con.Close();
            }

        }


    }
}


