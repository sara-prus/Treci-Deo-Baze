using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public  class Materijal
    {
        public virtual int ID { get; set; }

        public virtual string Tip_Materijala { get; set; }

        public virtual Predmet Pripada_predmetu { get; set; }
    }

  
}
