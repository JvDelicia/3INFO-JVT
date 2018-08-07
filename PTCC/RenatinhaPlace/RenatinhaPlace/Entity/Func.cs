using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Func : People {
        //public virtual People People { get; set; }
        //public int PeopleId { get; set; }
        public string Address { get; set; }
        public virtual FuncType Type { get; set; }
        public int TypeId { get; set; }
        public string User { get; set; }
         public string Pass { get; set; }

    }
}
