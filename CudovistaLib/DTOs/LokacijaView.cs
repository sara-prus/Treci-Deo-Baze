using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class LokacijaView
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_lokacije { get; set; }
        public virtual string Tip_lokacije { get; set; }
        public virtual string Zemlja { get; set; }
        public virtual string Blago { get; set; }
        public PredstavnikView Borio_se;

        public IList<ZastitaView> Zastite;
        //public IList<Zivi_naView> ZivePredstavnici;


        public LokacijaView()
        {
             Zastite = new List<ZastitaView>();
            //ZivePredstavnici = new List<Zivi_naView>();

        }

        public LokacijaView(Lokacija l)
        {
            ID = l.ID;
            Naziv_lokacije = l.Naziv_lokacije;
            Tip_lokacije = l.Tip_lokacije;
            Zemlja = l.Zemlja;
            Blago = l.Blago;
            this.Borio_se = new PredstavnikView(l.Borio_se);
          
    }

    }
}
