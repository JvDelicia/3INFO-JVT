using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public abstract class People {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime DueDt { get; set; }
        public string Rg { get; set; }
        public string Sex { get; set; }
        public string Tel { get; set; }
    }
}
