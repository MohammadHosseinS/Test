using System.Threading.Tasks;

namespace Service
{
    public interface IGeneralService
    {
        Task<string> GetValue(string key);
    }
}
