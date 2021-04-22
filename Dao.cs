using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    class Dao
    {
        public SqlConnection connection()
        {
            string str = "Data Source=DESKTOP-20TL7J6;Initial Catalog=StaffData;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开数据库连接
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, connection());
            return sc;
        }
        //用于delete insert updata 并返回受影响的行数
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //用于select，返回SQLDataReader对象，包含select的对象
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
