using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class ItemAcc {
        //CONCATENAR CHAVE
        public virtual Account Account { get; set; }
        public int AccountId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public int Qnt { get; set; }
    }
}
