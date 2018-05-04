using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeAvaliacao.Entities;

namespace ExeAvaliacao {
    public class StudDAO {
        private EntitiesContext context;

        public StudDAO() { context = new EntitiesContext(); }

        public void Add(Stud stud) {
            context.Studs.Add(stud);
            context.SaveChanges();
        }
    }
}
