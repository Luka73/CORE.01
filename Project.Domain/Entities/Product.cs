using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Entities
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int StockId { get; set; }
        #endregion

        #region Navegation
        public Stock Stock { get; set; }
        #endregion
    }
}
