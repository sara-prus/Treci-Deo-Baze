using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class LokacijaMapiranja : ClassMap<Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("LOKACIJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip_lokacije).Column("TIP_LOKACIJE");
            Map(x => x.Naziv_lokacije).Column("NAZIV_LOKACIJE");
            // Map(x => x.tip).Column("Tip_lokacije");
            Map(x => x.Zemlja).Column("ZEMLJA");
            Map(x => x.Blago).Column("BLAGO");

            HasOne(x => x.Borio_se).Cascade.All();
            HasMany(x => x.Zastite).KeyColumn("ID_LOKACIJE").LazyLoad().Cascade.All().Inverse();
            //mapiranje zivi na veze
            HasMany(x => x.ZivePredstavnici).KeyColumn("Id_lokacije").LazyLoad().Cascade.All().Inverse();
        }
    }

   
}