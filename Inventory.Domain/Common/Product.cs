using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Common
{
    public class Product:BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal CurrentStock { get; set; }

        public decimal MinimumStock { get; set; }

        public Guid CategoryId { get; set; }

        public Guid UnitId { get; set; }
    }
}
