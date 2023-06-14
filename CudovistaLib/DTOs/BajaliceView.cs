using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    internal class BajaliceView
    {
        public virtual int ID { get; set; }
        public virtual string Bajalica { get; set; }
        public virtual CudovisteView Id_cudovista { get; set; }

        public BajaliceView() { }
        public BajaliceView(Bajalice bajalica)
        {
            ID = bajalica.ID;
            Bajalica=bajalica.Bajalica;
        }
    }
}
