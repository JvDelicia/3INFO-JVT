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
        public decimal Price { get; set; }
        public virtual Event Event { get; set; }
        public int EventId { get; set; }
        public virtual IList<Account> Account { get; set; }
        
    }
}
