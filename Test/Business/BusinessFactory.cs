using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessFactory
    {
        private static IGeneral general;

        public static IGeneral General(string connectionString) =>
            general ?? (general=new General(ServiceFactory.GeneralBuilder(connectionString)));


    }
}
