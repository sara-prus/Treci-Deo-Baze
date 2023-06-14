using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class PredmetView
    {
        public virtual int ID { get; set; }
        public virtual CudovisteView Id_cudovista { get; set; }
        public  virtual MaterijalView ID_Materijala { get; set; }
        public virtual string Tip_Predmeta { get; set; }


        public PredmetView(Predmet p)
        {
            this.ID = p.ID;
            this.Id_cudovista = new CudovisteView(p.Id_cudovista);
            this.ID_Materijala = new MaterijalView(p.ID_Materijala);
            this.Tip_Predmeta = p.Tip_Predmeta;
        }

        public PredmetView()
        {
        }
    }
}
