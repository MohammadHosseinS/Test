using Service;
using System;
using System.Threading.Tasks;

namespace Business
{
    internal class General : IGeneral
    {
        private readonly IGeneralService _generalService;

        public General(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        public async Task<ServiceResponse<string>> GetValue(string key)
        {
            var response=new ServiceResponse<string>();

            try
            {
                var data=await _generalService.GetValue(key);
                response.SetData(data);
            }
            catch (Exception ex)
            {
                response.SetError(ex);
            }

            return response;
        }
    }
}
