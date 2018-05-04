using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Entities {
    public class ProdSale {
        public int SaleId { get; set; }
        public virtual Sale Sales { get; set; }
        public int ProdID { get; set; }
        public virtual Product Products { get; set; }
    }
}
