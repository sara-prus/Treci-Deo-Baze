
using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;

namespace CudovistaLib.Mapiranja
{

    public class MaterijalMapiranja : ClassMap<Materijal>
    {
        public MaterijalMapiranja()
        {

            Table("MATERIJAL");

           /* DiscriminateSubClassesOnColumn("Tip_Materijala");*/


            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip_Materijala, "Tip_Materijala");
            HasOne(x => x.Pripada_predmetu).PropertyRef(x => x.ID_Materijala);


        }

    }
   /* class ZlatoMapiranja : SubclassMap<Zlato>
    {
        public ZlatoMapiranja()
        {
            DiscriminatorValue("Zlato");
        }
    }
    class SrebroMapiranja : SubclassMap<Srebro>
    {
        public SrebroMapiranja()
        {
            DiscriminatorValue("Srebro");
        }
    }
    class PapirMapiranja : SubclassMap<Papir>
    {
        public PapirMapiranja()
        {
            DiscriminatorValue("Papir");
        }
    }
    class DijamantMapiranja : SubclassMap<Dijamant>
    {
        public DijamantMapiranja()
        {
            DiscriminatorValue("Dijamant");
        }
    }
    class MetalMapiranja : SubclassMap<Metal>
    {
        public MetalMapiranja()
        {
            DiscriminatorValue("Metal");
        }
    }*/
}

