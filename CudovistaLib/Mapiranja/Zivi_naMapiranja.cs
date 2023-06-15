using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{
    public class Zivi_naMapiranja : ClassMap<Zivi_na>
    {
        public Zivi_naMapiranja()
        {
            Table("ZIVI_NA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.PredstavnikZivi).Column("Id_predstavnika"); 
            References(x => x.LokacijaZivota).Column("Id_lokacije");

        }
    }
}