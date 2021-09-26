using System;
using Oracle.ManagedDataAccess.Client;
namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //db 접속 여러가지 방법
            // 오라클 연결 문자열         
            // DB클라이언트홈 에 있는 tnsnames.ora에 지정된 SERVICE_NAME을 데이터소스에 지정하고 사용자명과 암호를 지정한다.
            string strConn = "Data Source=orcl;User Id=capid;Password=cappw;";
            // 오라클 연결
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            conn.Close();

            //현재 작성자의 tnsnames.ora HOST정보는 localhost 이며 집에서 단독으로 이용할때 사용한다.
            //다른 사람의 주소에 들어갈 경우에는 그 사람의 ip주소를 입력하는 식으로 사용하게 된다.

            //tnsnames.ora 를 사용ㅎ지 않고 직접 네트워크 연결정보를 넣어서 사용할 수도 있다.
            string s = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=capid;Password=cappw;";
            conn = new OracleConnection(s);
            conn.Open();
            conn.Close();
        }
    }
}
