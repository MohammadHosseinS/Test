using System.Threading.Tasks;

namespace Business
{
    public interface IGeneral
    {
        Task<ServiceResponse<string>> GetValue(string key);
    }
}
