using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{

    public class CudovisteMapiranja : ClassMap<CudovistaLib.Entiteti.Cudoviste>
    {
        public CudovisteMapiranja()
        {
            Table("CUDOVISTE"); //proveri da li su tabele veliki slovima

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity(); ;

            Map(x => x.Vek).Column("VEK");
            Map(x => x.Naziv_cudovista).Column("NAZIV_CUDOVISTA");
            Map(x => x.Podtip).Column("PODTIP");

            HasMany(x => x.Predmeti).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Legende).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Predstavnici).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Protivmere).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Bajalice).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();

        }
    }
}