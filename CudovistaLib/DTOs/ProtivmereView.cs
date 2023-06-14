using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class ProtivmereView
    {
        public int ID;
        public string Naziv_protivmere;
        public string Opis_protivmere;
        public int Da_li_uslovi;
        public CudovisteView Id_cudovista;

        public ProtivmereView()
        {

        }
        public ProtivmereView(Protivmere p)
        {
            this.ID = p.ID;
            this.Naziv_protivmere = p.Naziv_protivmere;
            this.Opis_protivmere = p.Opis_protivmere;
            this.Da_li_uslovi = p.Da_li_uslovi;
            this.Id_cudovista = new CudovisteView(p.Id_cudovista);

        }
    }
}
