using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs
{
    public class Specijalne_sposobnostiView
    {
        public virtual int ID { get; set; }
        public virtual string Spec_sposobnosti { get; set; }
        public virtual CudovisteView Id_cudovista { get; set; }

        public Specijalne_sposobnostiView()
        {

        }
        public Specijalne_sposobnostiView(Specijalne_sposobnosti s)
        {
            this.ID = s.ID;
            this.Spec_sposobnosti = s.Spec_sposobnosti;
            this.Id_cudovista = new CudovisteView(s.Id_cudovista);        
        }
    }
}
