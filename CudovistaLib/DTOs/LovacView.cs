using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class LovacView
    {
        public virtual int ID { get; set; }
        public virtual string Ime_lovca { get; set; }
        public virtual PredstavnikView? Id_predstavnika { get; set; }


        public LovacView()
        {
           
        }

        public LovacView(Lovac p)
        {
            ID = p.ID;
            Ime_lovca = p.Ime_lovca;
            Id_predstavnika = new PredstavnikView(p.Id_predstavnika);
           

        }

        }
}
