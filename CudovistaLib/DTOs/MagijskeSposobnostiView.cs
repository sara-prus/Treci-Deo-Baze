using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class MagijskeSposobnostiView
    {
        public virtual int ID { get; set; }
        public virtual string Naziv_sposobnosti { get; set; }
        public virtual int Da_li_je_odbrambena { get; set; }
        public virtual string Opis_sposobnosti { get; set; }
        public virtual MagijskoView Id_cudovista { get; set; }
        public MagijskeSposobnostiView() { }
        public MagijskeSposobnostiView(Magijske_sposobnosti magijske)
        { 
            ID = magijske.ID;
            Naziv_sposobnosti = magijske.Naziv_sposobnosti;
            Da_li_je_odbrambena = magijske.Da_li_je_odbrambena;
            Opis_sposobnosti= magijske.Opis_sposobnosti;
            Id_cudovista = new MagijskoView(magijske.Id_cudovista);
        }
        
    }
}
