using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs.TipMaterijala
{
    public class MetalView : MaterijalView
    {
        public MetalView() { }
        public MetalView(Materijal m)   : base(m) { }
    }
}
