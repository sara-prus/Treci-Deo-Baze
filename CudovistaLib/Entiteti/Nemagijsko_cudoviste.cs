using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CudovistaLib.Entiteti
{
    public class Nemagijsko_cudoviste : Cudoviste
    {
        
        public virtual int Da_li_zivi_u_vodi { get; set; }
        public virtual int Da_li_leti { get; set; }
        public virtual int Da_li_ima_rep { get; set; }
        public virtual int Da_li_je_otrovno { get; set; }
        public virtual int Da_li_ima_kandze { get; set; }
        public virtual int Broj_ociju { get; set; }
        public virtual int Broj_glava { get; set; }
        public virtual int Broj_ekstremiteta { get; set; }
        public virtual int Duzina { get; set; }
        public virtual int Tezina { get; set; }


    }
}
