using Business;
using System.Threading.Tasks;

namespace TestProject
{
    internal class NewClass
    {
        IGeneral general;
        public NewClass(string connectionString)
        {
            general = BusinessFactory.General(connectionString);
        }

        public  async Task<string> GetValue(string message)
        {
            

            var response = await general.GetValue(message);
            if (!response.Success)
            {
                return $"ERROR {response.GetError()}";
            }


            return response.Data;
        }

    }
}
