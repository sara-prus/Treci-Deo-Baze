using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class LegendeView
    {

        public virtual int ID { get; set; }
        public virtual string Tekst { get; set; }
        public virtual DateTime Prvo_pominjanje { get; set; }
        public  virtual string Zemlja_porekla { get; set; }
        public virtual CudovisteView Id_cudovista { get; set; }

        public LegendeView()
        {

        }
        public LegendeView(Legende l)
        {
            this.ID = l.ID;
            this.Tekst = l.Tekst;
            this.Prvo_pominjanje = l.Prvo_pominjanje;
            this.Zemlja_porekla = l.Zemlja_porekla;
            this.Id_cudovista = new CudovisteView(l.Id_cudovista);

        }
    }
}
