using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    internal class CudovisteView
    {
        public virtual int ID { get; set; }
        public virtual int Vek { get; set; }
        public virtual string Naziv_cudovista { get; set; }
        public virtual string Podtip { get; set; }

        public CudovisteView() { }
        public CudovisteView(Cudoviste cudoviste)
        {
            ID=cudoviste.ID;
            Vek = cudoviste.Vek;
            Naziv_cudovista = cudoviste.Naziv_cudovista;
            Podtip = cudoviste.Podtip;
        }
    }
}
