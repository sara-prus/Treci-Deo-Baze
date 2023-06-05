

namespace CudovistaLib.Entiteti
{
    public class Cudoviste
    {
        public virtual int ID { get; set; }
        public virtual int Vek { get; set; }
        public virtual string Naziv_cudovista { get; set; }
        public virtual string Podtip { get; set; }

        public virtual IList<Protivmere> Protivmere { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual IList<Predstavnik> Predstavnici { get; set; }
        public virtual IList<Legende> Legende { get; set; }
        public virtual IList<Bajalice> Bajalice { get; set; }



        public Cudoviste()
        {
       /*     Protivmere = new List<Protivmere>();
            Predmeti = new List<Predmet>();
            Predstavnici = new List<Predstavnik>();
            Legende = new List<Legende>();
            Bajalice = new List<Bajalice>();*/

        }
    }
}
