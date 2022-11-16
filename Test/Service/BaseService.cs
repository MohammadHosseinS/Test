using System.Data;
using System.Data.SqlClient;

namespace Service
{
    internal class BaseService
    {
        protected IDbConnection Db  ;

        public BaseService(string connectionString)
        {
            if(Db==null)
                Db=new SqlConnection(connectionString);

        }

    }
}
