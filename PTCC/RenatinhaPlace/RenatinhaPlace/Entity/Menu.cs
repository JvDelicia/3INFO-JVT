using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Menu {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual IList<ItemMenu> ItemMenus { get; set; }
    }
}
