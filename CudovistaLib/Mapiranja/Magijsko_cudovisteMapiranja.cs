using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class Magijsko_cudovisteMapiranja : SubclassMap<Magijsko_cudoviste>
    {
        public Magijsko_cudovisteMapiranja()
        {
            Table("MAGIJSKO_CUDOVISTE");

            KeyColumn("ID");

            Map(x => x.Da_li_postoji).Column("DA_LI_POSTOJI");

            HasMany(x => x.Poseduje_sposobnosti).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
        }
    }
}

