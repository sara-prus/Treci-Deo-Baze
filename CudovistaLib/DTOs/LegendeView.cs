using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    internal class LegendeView
    {

        public int ID;
        public string Tekst;
        public DateTime Prvo_pominjanje;
        public string Zemlja_porekla;
        public CudovisteView Id_cudovista;

        public LegendeView()
        {

        }
        public LegendeView(Legende l)
        {
            this.ID = l.ID;
            this.Tekst = l.Tekst;
            this.Prvo_pominjanje = l.Prvo_pominjanje;
            this.Zemlja_porekla = l.Zemlja_porekla;
            this.Id_cudovista = new CudovisteView(l.Id_cudovista);

        }
    }
}
