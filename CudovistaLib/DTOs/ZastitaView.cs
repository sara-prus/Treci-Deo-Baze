using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class ZastitaView
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_zastite { get; set; }

        public virtual string Tip_zastite { get; set; }
        public virtual LokacijaView Id_lokacije { get; set; }


        public ZastitaView()
        {


        }

        public ZastitaView(Zastita z)
        {
            this.ID = z.ID;
            this.Naziv_zastite = z.Naziv_zastite;
            this.Tip_zastite = z.Tip_zastite;
            this.Id_lokacije = new LokacijaView(z.Id_lokacije); 


        }
    }
}
