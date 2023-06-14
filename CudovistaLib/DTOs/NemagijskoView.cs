using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class NemagijskoView : CudovisteView
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

        public NemagijskoView() { } 
        public NemagijskoView(Nemagijsko_cudoviste nemagijsko) : base(nemagijsko)
        {
            Da_li_zivi_u_vodi = nemagijsko.Da_li_zivi_u_vodi;
            Da_li_leti = nemagijsko.Da_li_leti;
            Da_li_ima_rep = nemagijsko.Da_li_ima_rep;
            Da_li_je_otrovno = nemagijsko.Da_li_je_otrovno;
            Da_li_ima_kandze = nemagijsko.Da_li_ima_kandze;
            Broj_ociju = nemagijsko.Broj_ociju;
            Broj_glava = nemagijsko.Broj_glava;
            Broj_ekstremiteta = nemagijsko.Broj_ekstremiteta;
            Duzina = nemagijsko.Duzina;
            Tezina = nemagijsko.Tezina;
        }
    }
}
