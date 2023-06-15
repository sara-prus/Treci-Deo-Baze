using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Predstavnik
    {
        public virtual int ID { get; set; }
        public virtual string Ime_predstavnika { get; set; }
        public virtual int Starost { get; set; }
        public virtual DateTime Datum_susreta { get; set; }
        public virtual string Ishod { get; set; }
        public virtual Cudoviste? Id_cudovista { get; set; }
        public virtual Lokacija? Id_lokacije { get; set; }

        public virtual IList<Lovac> Love_ga { get; set; }
        public virtual IList<Zivi_na> ZiveNaLokacijama { get; set; }  //ne diraj dovrsicu jos ovo m

        public Predstavnik()
        {
            Love_ga = new List<Lovac>();
            ZiveNaLokacijama = new List<Zivi_na>();
        }
    }

}