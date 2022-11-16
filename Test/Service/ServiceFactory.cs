using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ServiceFactory
    {
        private static IGeneralService general;

        public static IGeneralService GeneralBuilder(string connectionString) =>
            general ?? (general = new GeneralService(connectionString));

    }
}
