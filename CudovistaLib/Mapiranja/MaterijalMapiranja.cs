
using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{

    public class MaterijalMapiranja : ClassMap<Materijal>
    {
        public MaterijalMapiranja()
        {

            Table("MATERIJAL");



            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip_Materijala, "Tip_Materijala");
            HasOne(x => x.Pripada_predmetu).PropertyRef(x => x.ID_Materijala);


        }

    }
  
}

