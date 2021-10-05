using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace testDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dbIp = "222.239.64.185";
            //string dbName = "deskDB";
            //string dbId = "c##capstone";
            //string dbPw = "capstone1234";
            //string strConn = string.Format($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");

            //OracleConnection conn = new OracleConnection(strConn);
            //conn.Open();
            //System.Console.WriteLine("연결 완료!");
            //conn.Close();
            procedure a = new procedure();
            a.procedure_test();
        }
    }

    class procedure
    {
        static string dbIp = "222.239.64.185";
        static string dbName = "deskDB";
        static string dbId = "c##capstone";
        static string dbPw = "capstone1234";
        string strConn = string.Format($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
        public void procedure_test()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_att_firstclass";
            cmd.Parameters.Add("v_stu_no", OracleDbType.Varchar2).Value = "201607009";
            cmd.Parameters.Add("v_lec_code", OracleDbType.Varchar2).Value = "022";
            cmd.Parameters.Add("v_week_count", OracleDbType.Decimal).Value = 01; //Decimal = number
            cmd.Parameters.Add("v_att_inf", OracleDbType.Varchar2).Value = "1";

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine("반영된 열의 개수 " + result);
            conn.Close();
        }
    }
}