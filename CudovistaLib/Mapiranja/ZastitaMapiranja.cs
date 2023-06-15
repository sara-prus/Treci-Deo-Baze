using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class ZastitaMapiranja : ClassMap<Zastita>
    {
        public ZastitaMapiranja()
        {
            Table("ZASTITA");


            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_zastite).Column("NAZIV_ZASTITE");
            Map(x => x.Tip_zastite).Column("Tip_Zastite");
            References(x => x.Id_lokacije).Column("ID_LOKACIJE").LazyLoad();
        }
    }
  


}

