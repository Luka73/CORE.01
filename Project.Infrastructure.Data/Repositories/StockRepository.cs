using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using Project.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infrastructure.Data.Repositories
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        private readonly DataContext context;

        public StockRepository(DataContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
