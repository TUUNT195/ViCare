
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ViHISSrv.Data.UnitOfWork
{
    public class DatabaseFactories
    {
     
        private const string DichVuCongPortalConection = "SiteSqlServer";
     

        static DatabaseFactories()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
        }

        public static Database CreateDichVuCongPortalDatabase()
        {
            return DatabaseFactory.CreateDatabase(DichVuCongPortalConection);
        }
      
        
    }
}
