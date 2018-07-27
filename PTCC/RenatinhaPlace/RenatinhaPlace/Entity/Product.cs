using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal PriceUni { get; set; }
        public virtual IList<ItemMenu> ItemMenus { get; set; }
        public virtual IList<ItemAcc> ItemAccs { get; set; }


    }
}
