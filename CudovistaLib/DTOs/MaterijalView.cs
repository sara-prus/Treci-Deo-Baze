using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class MaterijalView
    {
        public virtual int ID { get; set; }

        //public virtual string Tip_Materijala { get; set; }

        public virtual  PredmetView Pripada_predmetu { get; set; }


        public MaterijalView(Materijal m)
        {
            this.ID = m.ID;
            this.Pripada_predmetu = new PredmetView(m.Pripada_predmetu);
           // this.Tip_Materijala = m.Tip_Materijala;
        }

        public MaterijalView()
        {
        }

    }
}
