using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs.TipMaterijala
{
    public class ZlatoView : MaterijalView
    {
        public ZlatoView() { }  
        public ZlatoView(Materijal m) : base(m) 
        {
        }
    }
}
