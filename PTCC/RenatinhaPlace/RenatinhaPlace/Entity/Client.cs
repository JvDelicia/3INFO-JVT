using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    class Client {
        public virtual People People { get; set; }
        public int PeopleId { get; set; }
    }
}
