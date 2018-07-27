using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class ItemMenu {
        public int Id { get; set; }
        public virtual Menu Menu { get; set; }
        public int MenuId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
