using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_di_ioc.Adapters.ByServiceLocator
{
    public static class ServiceLocators
    {
        private static IDictionary<string, Object> services = new Dictionary<string, Object>();

        public static T Get<T>(string id)
        {
            return (T)services[id];
        }

        public static bool Has(string id)
        {
            return services.ContainsKey(id);
        }

        public static void Register(string id, Object service)
        {
            if(service == null)
            {
                throw new Exception("Service not instantiated.");
            }

            services.Add(id, service);
        }
    }
}
