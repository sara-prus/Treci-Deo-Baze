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



        public PredstavnikView()
        {

        }
        public PredstavnikView(Predstavnik p)
        {
            this.ID = p.ID;
            this.Ime_predstavnika = p.Ime_predstavnika;
            this.Starost = p.Starost;
            this.DatumSusreta = p.Datum_susreta;
            this.Ishod = p.Ishod;
            this.Id_cudovista =  new CudovisteView(p.Id_cudovista);
            this.Id_lokacije = new LokacijaView(p.Id_lokacije);

        }
    }
}
