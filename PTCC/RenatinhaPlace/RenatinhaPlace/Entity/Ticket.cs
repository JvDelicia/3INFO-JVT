using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Ticket {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public virtual Account Account { get; set; }
        public int AccountId { get; set; }
    }
}
