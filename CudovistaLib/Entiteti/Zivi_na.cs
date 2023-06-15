using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Zivi_na
    {
        public virtual int ID { get; set; }
      /*  public virtual int Id_lokacije { get; set; }
        public virtual int Id_predstavnika { get; set; } */
        public virtual Predstavnik PredstavnikZivi { get; set; }
        public virtual Lokacija LokacijaZivota { get; set; }


    }
}