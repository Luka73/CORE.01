using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Service
{
    public class ProductDomainService : BaseDomainService<Product>, IProductDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.ProductRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
