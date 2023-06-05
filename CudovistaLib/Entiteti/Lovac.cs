using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Lovac
    {
        public virtual int ID { get; set; }
        public virtual string Ime_lovca { get; set; }
        public virtual Predstavnik Id_predstavnika { get; set; }

    }
}
