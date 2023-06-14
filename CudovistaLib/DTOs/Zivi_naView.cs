using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public  class Zivi_naView
    {
        public virtual int ID { get; set; }
        //public int Id_lokacije;
        //public int Id_predstavnika;
        public virtual PredstavnikView predstavnikZivi { get; set; }
        public virtual LokacijaView lokacijaZivota { get; set; }

        public Zivi_naView()
        {

        }
        public Zivi_naView(Zivi_na z)
        {
            this.ID = z.ID;
            this.predstavnikZivi = new PredstavnikView(z.PredstavnikZivi);
            this.lokacijaZivota = new LokacijaView(z.LokacijaZivota);

        }
    }
}
