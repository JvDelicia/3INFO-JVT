using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoAlunoNota.Entidades {
    public class Aluno {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual IList<Nota> Notas { get; set; }
    }
}
