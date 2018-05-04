using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Entities {
    public class Sale {
        public virtual User Client { get; set; }
        public int ClientID { get; set; }
        public IList<ProdSale> ProdSales { get; set; }
    }
}
