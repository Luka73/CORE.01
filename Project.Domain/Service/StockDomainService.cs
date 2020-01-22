using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Service
{
    public class StockDomainService : BaseDomainService<Stock>, IStockDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public StockDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.StockRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
