using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public  class Lokacija
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_lokacije { get; set; }
        public virtual string Tip_lokacije { get; set; }
        public virtual string Zemlja { get; set; }
        public virtual string Blago { get; set; }
        public virtual Predstavnik Borio_se { get; set; }
        public virtual IList<Zastita> Zastite { get; set; }
        public virtual IList<Zivi_na> ZivePredstavnici { get; set; } 
      
       

        public Lokacija()
        {
            Zastite = new List<Zastita>();
            ZivePredstavnici = new List<Zivi_na>();
        }
    }
}