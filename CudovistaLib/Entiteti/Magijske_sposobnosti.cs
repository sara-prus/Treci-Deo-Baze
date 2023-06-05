using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Magijske_sposobnosti
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_sposobnosti { get; set; }
        public virtual int Da_li_je_odbrambena { get; set; }
        public virtual string Opis_sposobnosti { get; set; }
        public virtual Magijsko_cudoviste Id_cudovista { get; set; }

    }
}
