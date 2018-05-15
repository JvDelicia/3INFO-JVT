using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class ItemMenu {
        public int Id { get; set; }
        public virtual IList<Func> Funcs { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
