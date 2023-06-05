using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class PredstavnikMapiranja : ClassMap<Predstavnik>
    {
        public PredstavnikMapiranja()
        {
            Table("PREDSTAVNIK");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime_predstavnika).Column("IME_PREDSTAVNIKA");
            Map(x => x.Starost).Column("STAROST");
            Map(x => x.Datum_susreta).Column("DATUM_SUSRETA");
            Map(x => x.Ishod).Column("ISHOD");

            //mapiranje veze 1:N Cudoviste-Predstavnik
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();
            References(x => x.Id_lokacije).Unique().Column("Id_lokacije").LazyLoad();

            HasMany(x => x.Love_ga).KeyColumn("Id_predstavnika").LazyLoad().Cascade.All().Inverse();
            //mapiranje zivi na
            HasMany(x => x.ZiveNaLokacijama).KeyColumn("Id_predstavnika").LazyLoad().Cascade.All().Inverse();

        }
    }
}