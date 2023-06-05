using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Specijalne_sposobnosti
    {
        public virtual int ID { get; set; }
        public virtual string Spec_sposobnosti { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; }
    }
}
