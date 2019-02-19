using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Poco;

namespace Library_Managment_System_Integrated
{
    class Member_Maintenance_Bl
    {
        Member_Maintenance_Impl mmi;
        public List<Member> findMember(int mId, string mName)
        {

            mmi = new Member_Maintenance_Impl();
            List<Member> members = new List<Member>();
            members = mmi.Read_Member(mId, mName);
            return members;
        }
    }
}


