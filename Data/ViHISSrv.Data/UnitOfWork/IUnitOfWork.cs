
using System;
using System.Transactions;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ViHISSrv.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Database DichVuCongPortalDatabase { get; }
      

        void SaveChanges();
        TransactionScope Transaction { get; }
    }
}
