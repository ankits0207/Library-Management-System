using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace Library_Managment_System_Integrated
{
    public class Connection
    {
        static OracleConnection con;
        static Connection myObj=new Connection();
        private Connection()
        {
            con = new OracleConnection("SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ITEM-70282.dhcp.noid.in.sopra)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=SopraTest)));uid=scott;pwd=tiger;");

        }

        public static OracleConnection returnConnection()
        {
            return con;
        }
    }
}
