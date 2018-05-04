﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    class FuncType {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Access { get; set; }
        public virtual IList<Func> Funcs { get; set; }
    }
}