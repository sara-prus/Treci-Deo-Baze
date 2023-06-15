using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib.Entiteti
{
    public class Predmet
    {
        public virtual int ID { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; }
        public virtual Materijal ID_Materijala { get; set; }

        public virtual string Tip_Predmeta { get; set; }

    }

   /* public class Lobanja : Predmet
    {

    }

    public class Krst : Predmet
    {

    }
    public class Mac : Predmet
    {

    }

    public class Knjiga : Predmet
    {

    }*/
}
