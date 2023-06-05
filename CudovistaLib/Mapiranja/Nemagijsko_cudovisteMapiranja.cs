using FluentNHibernate.Mapping;
using CudovistaLib.Entiteti;
namespace CudovistaLib.Mapiranja
{
    public class Nemagijsko_cudovisteMapiranja : SubclassMap<Nemagijsko_cudoviste>
    {
        public Nemagijsko_cudovisteMapiranja()
        {

            Table("NEMAGIJSKO_CUDOVISTE");

            KeyColumn("ID");

            Map(x => x.Da_li_zivi_u_vodi).Column("DA_LI_ZIVI_U_VODI");
            Map(x => x.Da_li_leti).Column("DA_LI_LETI");
            Map(x => x.Da_li_ima_rep).Column("DA_LI_IMA_REP");
            Map(x => x.Da_li_je_otrovno).Column("DA_LI_JE_OTROVNO");
            Map(x => x.Da_li_ima_kandze).Column("DA_LI_IMA_KANDZE");
            Map(x => x.Broj_ociju).Column("BROJ_OCIJU");
            Map(x => x.Broj_ekstremiteta).Column("BROJ_EKSTREMITETA");
            Map(x => x.Broj_glava).Column("BROJ_GLAVA");
            Map(x => x.Duzina).Column("DUZINA");
            Map(x => x.Tezina).Column("TEZINA");

        }

    }

}
