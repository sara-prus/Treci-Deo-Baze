using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class PredstavnikView
    {
        public virtual int ID { get; set; }
        public virtual string Ime_predstavnika { get; set; }
        public virtual int Starost { get; set; }
        public virtual DateTime DatumSusreta { get; set; }
        public virtual string Ishod { get; set; }
        public virtual CudovisteView? Id_cudovista { get; set; }
        public virtual LokacijaView? Id_lokacije { get; set; }

        public virtual IList<Lovac>? Love_ga { get; set; }
        public virtual IList<Zivi_na>? ZiveNaLokacijama { get; set; }

        public PredstavnikView()
        {
            Love_ga=new List<Lovac>();
            ZiveNaLokacijama = new List<Zivi_na>();

        }
        public PredstavnikView(Predstavnik p)
        {
            ID = p.ID;
            Ime_predstavnika = p.Ime_predstavnika;
            Starost = p.Starost;
            DatumSusreta = p.Datum_susreta;
            Ishod = p.Ishod;
            Id_cudovista =  new CudovisteView(p.Id_cudovista);
            // Id_lokacije = new LokacijaView(p.Id_lokacije);

        }
    }
}
