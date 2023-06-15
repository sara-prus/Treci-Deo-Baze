using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public  class Zastita
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_zastite { get; set; }

        public virtual string? Tip_zastite { get; set; }
        public virtual Lokacija? Id_lokacije { get; set; }


    }

}
