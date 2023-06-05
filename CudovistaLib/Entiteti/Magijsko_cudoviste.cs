using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Magijsko_cudoviste : Cudoviste
    {
        public virtual int Da_li_postoji { get; set; }
        public virtual IList<Magijske_sposobnosti> Poseduje_sposobnosti { get; set; }
    }
}
