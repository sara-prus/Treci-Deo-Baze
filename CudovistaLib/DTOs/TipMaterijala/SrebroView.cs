using CudovistaLib.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.DTOs.TipMaterijala
{
    public class SrebroView : MaterijalView
    {
        public SrebroView() { }
        public SrebroView(Materijal materijal) : base(materijal) { }
    }
}
