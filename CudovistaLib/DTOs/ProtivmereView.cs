using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class ProtivmereView
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_protivmere { get; set; }
        public virtual string Opis_protivmere { get; set; }
        public virtual int Da_li_uslovi { get; set; }
        public virtual  CudovisteView Id_cudovista { get; set; }

        public ProtivmereView()
        {

        }
        public ProtivmereView(Protivmere p)
        {
            this.ID = p.ID;
            this.Naziv_protivmere = p.Naziv_protivmere;
            this.Opis_protivmere = p.Opis_protivmere;
            this.Da_li_uslovi = p.Da_li_uslovi;
            this.Id_cudovista = new CudovisteView(p.Id_cudovista);

        }
    }
}
