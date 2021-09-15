using Oracle.ManagedDataAccess.Client;
using Oracle.EntityFrameworkCore;
using System;
using System.Data.Odbc;
using System.Data.OracleClient;

namespace test_cap
{
    class DB_C
    {
        OracleConnection con;

        void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "User Id=capid;Password=cappw;Data Source=onj";
            con.Open();
            Console.WriteLine("오라클 접속 OK");
        }

        void Close()
        {
            con.Close();
            con.Dispose();
        }

        static void Main()
        {
            DB_C example = new DB_C();
            example.Connect();
            example.Close();
        }
    }
}