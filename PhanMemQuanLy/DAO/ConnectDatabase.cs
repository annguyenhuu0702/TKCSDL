using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class ConnectDatabase
    {
        private string DB_name = "QLBH_TKCSDL";
        private string DB_userID = "sa";
        private string DB_password = "0384974745";
        public SqlConnection Connect()
        {
            return new SqlConnection(
                $@"Data Source=TOPXOAN\SQLEXPRESS;Initial Catalog={DB_name};User ID={DB_userID};Password={DB_password}"
            );
        }
    }
}
