using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

           
            Map(x => x.Tip_Predmeta, "Tip_Predmeta");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje veze 1:N Cudoviste-Predmet
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();
            //MAPIRANJE ONE TO ONE
            References(x => x.ID_Materijala).Column("ID_Materijala").LazyLoad();

        }
    }
/*    class LobanjaMapiranja : SubclassMap<Lobanja>
    {
        public LobanjaMapiranja()
        {
            DiscriminatorValue("Lobanja");
        }
    }
    class KrstMapiranja : SubclassMap<Krst>
    {
        public KrstMapiranja()
        {
            DiscriminatorValue("Krst");
        }
    }
    class MacMapiranja : SubclassMap<Mac>
    {
        public MacMapiranja()
        {
            DiscriminatorValue("Mac");
        }
    }
    class KnjigaMapiranja : SubclassMap<Knjiga>
    {
        public KnjigaMapiranja()
        {
            DiscriminatorValue("Knjiga");
        }
    }*/
}
