using System.Data.Entity;

namespace EFDemo.DAL.Interceptor
{
    public class EfDemoDonfiguration : DbConfiguration
    {
        public EfDemoDonfiguration()
        {
            this.AddInterceptor(new CommandInterceptor());
        }
    }
}
