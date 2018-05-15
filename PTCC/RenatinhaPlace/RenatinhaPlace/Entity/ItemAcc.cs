using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class ItemAcc {
        public int Id { get; set; }
        public int Qnt { get; set; }
        public virtual Product Product { get; set; }
        public int ProdId { get; set; }
    }
}
