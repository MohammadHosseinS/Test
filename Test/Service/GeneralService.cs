using Dapper;
using System.Threading.Tasks;

namespace Service
{
    internal class GeneralService : BaseService, IGeneralService
    {
        public GeneralService(string connectionString):base(connectionString)
        {

        }

        public async Task<string> GetValue(string key)
        {
            return await Db.ExecuteScalarAsync<string>("GetValue", new { Message = key },
                commandType: System.Data.CommandType.StoredProcedure).ConfigureAwait(false);
        }
    }
}
