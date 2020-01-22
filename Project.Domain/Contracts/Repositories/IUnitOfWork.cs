using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        IProductRepository ProductRepository { get; }
        IStockRepository StockRepository { get; }
    }
}
