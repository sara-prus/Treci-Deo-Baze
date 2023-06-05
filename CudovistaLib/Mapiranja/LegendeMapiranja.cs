using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class LegendeMapiranja : ClassMap<Legende>
    {
        public LegendeMapiranja()
        {
            Table("LEGENDE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Tekst).Column("TEKST");
            Map(x => x.Prvo_pominjanje).Column("PRVO_POMINJANJE");
            Map(x => x.Zemlja_porekla).Column("ZEMLJA_POREKLA");

            //mapiranje veze 1:N Cudoviste-Legende
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();

        }
    }
}
