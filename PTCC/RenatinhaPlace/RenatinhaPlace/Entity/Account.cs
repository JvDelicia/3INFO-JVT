using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Account {
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }
        public string Status { get; set; }
        public virtual IList<ItemAcc> ItemAccs { get; set; }
    }
}
