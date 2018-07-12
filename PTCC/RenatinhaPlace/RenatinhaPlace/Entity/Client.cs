using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Client : People {
        public virtual People People { get; set; }
        public int PeopleId { get; set; }
    }
}
