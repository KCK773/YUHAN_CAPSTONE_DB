using System;
using Oracle.ManagedDataAccess.Client;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 오라클 연결 문자열        
            string strConn = "Data Source=orcl;User Id=capid;Password=cappw;";
           
            // 오라클 연결
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            //...
            conn.Close();
            Console.WriteLine("하아 시발 ㅋㅋㅋ");
            */
            select a = new select();
            a.select_test();
        }

    }
    class select
    {
        private string _strConn = "Data Source=orcl;User Id=capid;Password=cappw;";
        public void select_test()
        {
            // 오라클 서버 연결 객체 생성
            using (OracleConnection conn = new OracleConnection(_strConn))
            {
                // 커넥션 오픈
                conn.Open();
                // 커맨드 생성
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id, pw  FROM test_1";
                    // select 문 쿼리
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string pw = reader["pw"].ToString();

                            // 내부 처리
                            Console.WriteLine("아이디:" + id + "  비밀번호:"+pw);
                        }
                    }
                }
                conn.Close();
            }
            return;
        }
    }
}
