using CudovistaLib;
using CudovistaLib.DTOs;
using CudovistaLib.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CudovistaLib.Entiteti.Lokacija;

namespace CudovistaLib
{
   
    
    public class DataProvajderS

    {
    public static CudovisteView VratiCudoviste(int idCudovista)
    {
        CudovisteView cudoviste;
        try
        {
            ISession s = DataLayer.GetSession();
            Cudoviste o = s.Load<Cudoviste>(idCudovista);
            cudoviste = new CudovisteView(o);

            s.Close();
        }
        catch (Exception)
        {
            throw;
        }
        return cudoviste;
    }
        public static List<CudovisteView> VratiSvaCudovista()
        {
            List<CudovisteView> magijska = new List<CudovisteView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudoviste> svaMagijska = from o in s.Query<Cudoviste>()
                                                              select o;

                foreach (Cudoviste m in svaMagijska)
                {
                    magijska.Add(new CudovisteView(m));
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
        #region Bajalice
        public static void SacuvajBajalicu(BajaliceView bajalica, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalice o = new Bajalice();
                Cudoviste p = s.Load<Cudoviste>(idCudovista);

                o.Bajalica=bajalica.Bajalica;
                o.Id_cudovista = p;

                s.Save(o);
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
        #region Nemagijska

        public static NemagijskoView VratiNemagijskoCudoviste(int idCudovista)
        {
            NemagijskoView nemagijsko;
            try
            {
                ISession s = DataLayer.GetSession();
                Nemagijsko_cudoviste o = s.Load<Nemagijsko_cudoviste>(idCudovista);
                nemagijsko = new NemagijskoView(o);

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return nemagijsko;
        }
        public static List<NemagijskoView> VratiSvaNemagijska()
        {
            List<NemagijskoView> nemagijska = new List<NemagijskoView>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Nemagijsko_cudoviste> svaMagijska = from o in s.Query<Nemagijsko_cudoviste>()
                                                              select o;

                foreach (Nemagijsko_cudoviste m in svaMagijska)
                {
                    nemagijska.Add(new NemagijskoView(m));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return nemagijska;
        }
        public static void DodajNemagijskoCudoviste(NemagijskoView nemagijsko)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemagijsko_cudoviste o = new Nemagijsko_cudoviste
                {
                    Naziv_cudovista = nemagijsko.Naziv_cudovista,
                    Vek= nemagijsko.Vek,
                    Da_li_zivi_u_vodi = nemagijsko.Da_li_zivi_u_vodi,
                    Da_li_leti = nemagijsko.Da_li_leti,
                    Da_li_ima_rep = nemagijsko.Da_li_ima_rep,
                    Da_li_je_otrovno = nemagijsko.Da_li_je_otrovno,
                    Da_li_ima_kandze = nemagijsko.Da_li_ima_kandze,
                    Broj_ociju = nemagijsko.Broj_ociju,
                    Broj_glava = nemagijsko.Broj_glava,
                    Broj_ekstremiteta = nemagijsko.Broj_ekstremiteta,
                    Duzina = nemagijsko.Duzina,
                    Tezina = nemagijsko.Tezina,
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
        public static NemagijskoView AzurirajNemagijskoCudoviste(NemagijskoView nemagijsko)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemagijsko_cudoviste o = s.Load<Nemagijsko_cudoviste>(nemagijsko.ID);
                o.Naziv_cudovista = nemagijsko.Naziv_cudovista;
                o.Vek = nemagijsko.Vek;
                o.Da_li_zivi_u_vodi = nemagijsko.Da_li_zivi_u_vodi;
                o.Da_li_leti = nemagijsko.Da_li_leti;
                o.Da_li_ima_rep = nemagijsko.Da_li_ima_rep;
                o.Da_li_je_otrovno = nemagijsko.Da_li_je_otrovno;
                o.Da_li_ima_kandze = nemagijsko.Da_li_ima_kandze;
                o.Broj_ociju = nemagijsko.Broj_ociju;
                o.Broj_glava = nemagijsko.Broj_glava;
                o.Broj_ekstremiteta = nemagijsko.Broj_ekstremiteta;
                o.Duzina = nemagijsko.Duzina;
                o.Tezina = nemagijsko.Tezina;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return nemagijsko;
        }
        public static void ObrisiNemagijskoCudoviste(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nemagijsko_cudoviste o = s.Load<Nemagijsko_cudoviste>(ID);

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
        #region Magijske sposobnosti
        public static List<MagijskeSposobnostiView> VratiSposobnosti(int idCudovista)
        {
            List<MagijskeSposobnostiView> info= new List<MagijskeSposobnostiView> ();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Magijske_sposobnosti> sposobnosti = from o in s.Query<Magijske_sposobnosti>()
                                                      where o.Id_cudovista.ID == idCudovista
                                                              select o;


                foreach (Magijske_sposobnosti o in sposobnosti)
                {
                    var sp = new MagijskeSposobnostiView(o)
                    {
                        Id_cudovista = new MagijskoView(o.Id_cudovista)
                    };

                    info.Add(sp);
                }
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return info;
        }
        public static void DodajSposobnost(MagijskeSposobnostiView sposobnost, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Magijske_sposobnosti o = new Magijske_sposobnosti();
                Magijsko_cudoviste p = s.Load<Magijsko_cudoviste>(idCudovista);
                o.ID = sposobnost.ID;
                o.Naziv_sposobnosti = sposobnost.Naziv_sposobnosti;
                o.Da_li_je_odbrambena = sposobnost.Da_li_je_odbrambena;
                o.Opis_sposobnosti = sposobnost.Opis_sposobnosti;

                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static void SacuvajSposobnost(MagijskeSposobnostiView spos, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Magijske_sposobnosti o = new Magijske_sposobnosti();
                Magijsko_cudoviste p = s.Load<Magijsko_cudoviste>(idCudovista);

                o.Naziv_sposobnosti = spos.Naziv_sposobnosti;
                o.Opis_sposobnosti = spos.Opis_sposobnosti;
                o.Da_li_je_odbrambena = spos.Da_li_je_odbrambena;
                o.Id_cudovista = p;

                s.Save(o);
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
