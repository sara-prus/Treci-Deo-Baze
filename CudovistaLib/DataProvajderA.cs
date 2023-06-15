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
    public class DataProvajderA
    {
        public static List<ProtivmereView> vratiSveProtivmere()
        {
            List<ProtivmereView> protivmere = new List<ProtivmereView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Protivmere> sveProtivmere = from o in s.Query<Protivmere>()
                                                        select o;

                foreach (Protivmere p in sveProtivmere)
                {
                    protivmere.Add(new ProtivmereView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                throw;
            }

            return protivmere;
        }

        public static void dodajProtivmeru(ProtivmereView p, int idCudovista)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Protivmere o = new Protivmere();

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw;
            }
        }

        public static ProtivmereView azurirajProtivmeru(ProtivmereView p, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Protivmere o = s.Load<Protivmere>(p.ID);

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw;
            }

            return p;
        }

        public static ProtivmereView vratiProtivmeru(int id)
        {
            ProtivmereView pb;
            try
            {
                ISession s = DataLayer.GetSession();

                Protivmere p = s.Load<Protivmere>(id);
                pb = new ProtivmereView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                throw;
            }

            return pb;
        }

        public static void obrisiProtivmeru(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Protivmere o = s.Load<Protivmere>(id);
                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw;
            }
        }

        #region Legende
        public static List<LegendeView> vratiSvaLegende()
        {
            List<LegendeView> cudovista = new List<LegendeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Legende> sveLegende = from o in s.Query<Legende>()
                                                  select o;

                foreach (Legende p in sveLegende)
                {
                    cudovista.Add(new LegendeView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return cudovista;
        }

        public static void dodajLegendu(LegendeView p, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legende o = new Legende();

                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static LegendeView azurirajLegendu(LegendeView p, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legende o = s.Load<Legende>(p.ID);
                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static LegendeView vratiLegendu(int id)
        {
            LegendeView pb = new LegendeView();
            try
            {
                ISession s = DataLayer.GetSession();

                Legende p = s.Load<Legende>(id);
                pb = new LegendeView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiLegendu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legende o = s.Load<Legende>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Legende
        #region Specijalna Sposobnost

        public static List<Specijalne_sposobnostiView> vratiSveSpecijalneSposobnosti()
        {
            List<Specijalne_sposobnostiView> specijalneSposobnosti = new List<Specijalne_sposobnostiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Specijalne_sposobnosti> sveSpecijalneSposobnosti = from o in s.Query<Specijalne_sposobnosti>()
                                                                               select o;

                foreach (Specijalne_sposobnosti p in sveSpecijalneSposobnosti)
                {
                    specijalneSposobnosti.Add(new Specijalne_sposobnostiView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return specijalneSposobnosti;
        }

        public static void dodajSpecijalnuSposobnost(Specijalne_sposobnostiView p, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti o = new Specijalne_sposobnosti();

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static Specijalne_sposobnostiView azurirajSpecijalnuSposobnost(Specijalne_sposobnostiView p, int idCudovista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti o = s.Load<Specijalne_sposobnosti>(p.ID);

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                o.Id_cudovista = cudoviste;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static Specijalne_sposobnostiView vratiSpecijalnuSposobnost(int id)
        {
            Specijalne_sposobnostiView pb = new Specijalne_sposobnostiView();
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti p = s.Load<Specijalne_sposobnosti>(id);
                pb = new Specijalne_sposobnostiView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiSpecijalnuSposobnosti(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti p = s.Load<Specijalne_sposobnosti>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Specijalna Sposobnost

        #region Lokacija
        public static void SacuvajLokacijuBorba(int idLokacije, int idPredstavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik o = s.Load<Predstavnik>(idPredstavnika);
                Lokacija p = s.Load<Lokacija>(idLokacije);

                p.Borio_se = o;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

    

        public static void SacuvajLokacijuZastita(int idLokacije, int idPredstavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik o = s.Load<Predstavnik>(idPredstavnika);
                Lokacija p = s.Load<Lokacija>(idLokacije);

                Zivi_na z = new Zivi_na();
                z.LokacijaZivota = p;
                z.PredstavnikZivi = o;

                p.ZivePredstavnici.Add(z);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void SacuvajLokacijuPredstavnikZivi(int idLokacije, int idZastite)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastita o = s.Load<Zastita>(idZastite);
                Lokacija p = s.Load<Lokacija>(idLokacije);

                p.Zastite.Add(o);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        //--provera za materijal pomocan metoda
        public static string GetLokacijaValue(string lokacija)
        {
            string[] validLocations = { "Pecina", "Ostrvo", "Grad duhova", "Piramida", "Ukleti zamak" };

            for (int i = 0; i < validLocations.Length; i++)
            {
                if (string.Equals(validLocations[i], lokacija, StringComparison.OrdinalIgnoreCase))
                    return validLocations[i];
            }

            return ""; // Return "" if the material is invalid
        }


        public static void DodajLokaciju(LokacijaView lokacija, int idPredBorba, int idZastite, int idPredstavnika, string lokacijaStr)
        {
            try
            {
                string lokacijaValue = GetLokacijaValue(lokacijaStr);
                if (lokacijaValue != "")
                {

                    ISession s = DataLayer.GetSession();

                    Lokacija p = new Lokacija();
                    Predstavnik c = s.Load<Predstavnik>(idPredBorba);
                    Zastita m = s.Load<Zastita>(idZastite);
                    Predstavnik x = s.Load<Predstavnik>(idPredstavnika);

                    Zivi_na z = new Zivi_na();
                    z.LokacijaZivota = p;
                    z.PredstavnikZivi = x;

                    p.ID = lokacija.ID;
                    p.Tip_lokacije = lokacijaValue;
                    p.Blago = lokacija.Blago;
                    p.Zemlja = lokacija.Zemlja;
                    p.Naziv_lokacije = lokacija.Naziv_lokacije;
                    p.Borio_se = c;
                    p.Zastite.Add(m);
                    p.ZivePredstavnici.Add(z);

                    s.Save(p);
                    s.Flush();
                    s.Close();

                }

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void obrisilokaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija p = s.Load<Lokacija>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Lokacija

        #region Predstavnik

        public static List<PredstavnikView> vratiSvePredstavnike()
        {
            List<PredstavnikView> predstavnici = new List<PredstavnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavnik> sviPredstavnici = from o in s.Query<Predstavnik>()
                                                                              select o;

                foreach (Predstavnik p in sviPredstavnici)
                {
                    predstavnici.Add(new PredstavnikView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predstavnici;
        }

        public static void dodajPredstavnika(PredstavnikView o, int idCudovista, int idLokacije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik p = new Predstavnik();

                p.ID = o.ID;
                p.Ime_predstavnika = o.Ime_predstavnika;
                p.Starost = o.Starost;
                p.Datum_susreta = o.DatumSusreta;
                p.Ishod = o.Ishod;
                Cudoviste cudoviste = s.Load<Cudoviste>(idCudovista);
                p.Id_cudovista = cudoviste;

                Lokacija lokacija = s.Load<Lokacija>(idLokacije);
                p.Id_lokacije = lokacija;
                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static PredstavnikView azurirajPredstavnika(PredstavnikView o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik p = s.Load<Predstavnik>(o.ID);
                p.ID = o.ID;
                p.Ime_predstavnika = o.Ime_predstavnika;
                p.Starost = o.Starost;
                p.Datum_susreta = o.DatumSusreta;
                p.Ishod = o.Ishod;


                s.Update(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;
        }

        public static PredstavnikView VratiPredstavnika(int idCudovista)
        {
            PredstavnikView cudoviste;
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavnik o = s.Load<Predstavnik>(idCudovista);
                cudoviste = new PredstavnikView(o);

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return cudoviste;
        }

        public static void obrisiPredstavnika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik o = s.Load<Predstavnik>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Predstavnik

        #region Lovac

        public static List<LovacView> vratiSveLovce()
        {
            List<LovacView> lovci = new List<LovacView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lovac> sviLovci = from o in s.Query<Lovac>()
                                              select o;

                foreach (Lovac p in sviLovci)
                {
                    lovci.Add(new LovacView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lovci;
        }

        public static void dodajLovca(LovacView p, int idPredstavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = new Lovac();

                o.ID = p.ID;
                o.Ime_lovca = p.Ime_lovca;
                Predstavnik predstavnik = s.Load<Predstavnik>(idPredstavnika);
                o.Id_predstavnika = predstavnik;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static LovacView azurirajLovca(LovacView p, int idPredstavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = new Lovac();

                o.ID = p.ID;
                o.Ime_lovca = p.Ime_lovca;
                Predstavnik predstavnik = s.Load<Predstavnik>(idPredstavnika);
                o.Id_predstavnika = predstavnik;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return p;
        }

        public static LovacView vratiLovca(int id)
        {
            LovacView pb = new LovacView();
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac p = s.Load<Lovac>(id);
                pb = new LovacView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiLovca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac p = s.Load<Lovac>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Lovac
        #region Zastita
        public static void SacuvajZastituLokacija(int idZastite, int idLokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastita o = s.Load<Zastita>(idZastite);
                Lokacija p = s.Load<Lokacija>(idLokacija);

                o.Id_lokacije = p;

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





        //--provera za materijal pomocan metoda
        public static string GetZastitaValue(string lokacija)
        {
            string[] validZastita = { "Duh", "Zmaj", "Kletva" };

            for (int i = 0; i < validZastita.Length; i++)
            {
                if (string.Equals(validZastita[i], lokacija, StringComparison.OrdinalIgnoreCase))
                    return validZastita[i];
            }

            return ""; // Return "" if the material is invalid
        }


        public static void DodajZastitu(ZastitaView zastita, int idLokacija, string zastitaStr)
        {
            try
            {
                string zastitaValue = GetZastitaValue(zastitaStr);
                if (zastitaValue != "")
                {

                    ISession s = DataLayer.GetSession();

                    Zastita p = new Zastita();
                    Lokacija c = s.Load<Lokacija>(idLokacija);

                    p.ID = zastita.ID;
                    p.Naziv_zastite = zastita.Naziv_zastite;
                    p.Tip_zastite = zastitaValue;
                    p.Id_lokacije = c;

                    s.Save(p);
                    s.Flush();
                    s.Close();

                }

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void obrisiZastitu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastita p = s.Load<Zastita>(id);
                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Zastita

    }
}
