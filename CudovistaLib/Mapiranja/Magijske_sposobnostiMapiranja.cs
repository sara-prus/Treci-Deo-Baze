using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class Magisjke_sposobnostiMapiranja : ClassMap<Magijske_sposobnosti>
    {

        public Magisjke_sposobnostiMapiranja()
        {
            Table("MAGIJSKE_SPOSOBNOSTI");

            Id(x => x.ID, "ID_MAGIJSKE_SPOSOBNOSTI").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_sposobnosti).Column("NAZIV_SPOSOBNOSTI");
            Map(x => x.Da_li_je_odbrambena).Column("DA_LI_JE_ODBRAMBENA");
            Map(x => x.Opis_sposobnosti).Column("OPIS_SPOSOBNOSTI");

            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();

        }
    }
}

