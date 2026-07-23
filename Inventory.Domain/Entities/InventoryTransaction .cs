using Inventory.Domain.Common;
using Inventory.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    public class InventoryTransaction:BaseEntity
    {
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }

        public TransactionType Type { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
