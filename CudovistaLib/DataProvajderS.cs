using CudovistaLib.DTOs;
using CudovistaLib.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CudovistaLib
{
    public class DataProvajderS
    {
        #region Cudovista
        public static MagijskoView VratiMagijskoCudoviste(int idCudovista)
        {
            MagijskoView magijsko;
            try
            {
                ISession s = DataLayer.GetSession();
                Magijsko_cudoviste o= s.Load<Magijsko_cudoviste>(idCudovista);
                magijsko = new MagijskoView(o);

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return magijsko;
        }
        public static List<MagijskoView> VratiSvaMagijska()
        {
            List<MagijskoView> magijska = new List<MagijskoView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Magijsko_cudoviste> svaMagijska = from o in s.Query<Magijsko_cudoviste>()
                                                        select o;

                foreach (Magijsko_cudoviste m in svaMagijska)
                {
                    magijska.Add(new MagijskoView(m));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return magijska;
        }
        public static void DodajMagijskoCudoviste(MagijskoView m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Magijsko_cudoviste o = new Magijsko_cudoviste
                {
                    Naziv_cudovista= m.Naziv_cudovista,
                    Vek=m.Vek,
                    Podtip=m.Podtip,
                    Da_li_postoji=m.Da_li_postoji,

                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static MagijskoView AzurirajMagijskoCudoviste(MagijskoView m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Magijsko_cudoviste o = s.Load<Magijsko_cudoviste>(m.ID);
                o.Naziv_cudovista = m.Naziv_cudovista;
                o.Vek=m.Vek;
                o.Podtip=m.Podtip;
                o.Da_li_postoji= m.Da_li_postoji;
              
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return m;
        }
        public static void ObrisiMagijskoCudoviste(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Magijsko_cudoviste o = s.Load<Magijsko_cudoviste>(ID);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion
    }
}
