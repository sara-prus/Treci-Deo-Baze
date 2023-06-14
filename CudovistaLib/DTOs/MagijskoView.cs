using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class MagijskoView : CudovisteView
    {
        public virtual int Da_li_postoji { get; set; }
        public virtual IList<MagijskeSposobnostiView> Poseduje_sposobnosti { get; set; }

        public MagijskoView() {
            Poseduje_sposobnosti = new List<MagijskeSposobnostiView>();
        }
        public MagijskoView(Magijsko_cudoviste m) : base(m) 
        {
            Da_li_postoji=m.Da_li_postoji;
          
        }

    }
}
