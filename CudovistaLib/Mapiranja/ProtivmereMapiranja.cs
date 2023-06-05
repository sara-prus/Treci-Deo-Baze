using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class ProtivmereMapiranja : ClassMap<Protivmere>
    {
        public ProtivmereMapiranja()
        {

            Table("PROTIVMERE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_protivmere).Column("NAZIV_PROTIVMERE");
            Map(x => x.Opis_protivmere).Column("OPIS_PROTIVMERE");
            Map(x => x.Da_li_uslovi).Column("DA_LI_USLOVI");

            //mapiranje veze 1:N Cudoviste-Protuvmera
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();

        }
    }
}

