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
    public  class DataProvajderA
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

        public static void dodajProtivmeru(ProtivmereView p)
        {
            
            try
            {
                ISession s = DataLayer.GetSession();
                Protivmere o = new Protivmere();

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        public static ProtivmereView azurirajProtivmeru(ProtivmereView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Protivmere o = s.Load<Protivmere>(p.ID);

                o.ID = p.ID;
                o.Naziv_protivmere = p.Naziv_protivmere;
                o.Opis_protivmere = p.Opis_protivmere;
                o.Da_li_uslovi = p.Da_li_uslovi;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        public static void dodajLegendu(LegendeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legende o = new Legende();

                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        public static LegendeView azurirajLegendu(LegendeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legende o = s.Load<Legende>(p.ID);
                o.ID = p.ID;
                o.Tekst = p.Tekst;
                o.Prvo_pominjanje = p.Prvo_pominjanje;
                o.Zemlja_porekla = p.Zemlja_porekla;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        public static void dodajSpecijalnuSposobnost(Specijalne_sposobnostiView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti o = new Specijalne_sposobnosti();

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        public static Specijalne_sposobnostiView azurirajSpecijalnuSposobnost(Specijalne_sposobnostiView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalne_sposobnosti o = s.Load<Specijalne_sposobnosti>(p.ID);

                o.ID = p.ID;
                o.Spec_sposobnosti = p.Spec_sposobnosti;
                Cudoviste cudoviste = s.Load<Cudoviste>(p.Id_cudovista);
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

        #region Ostrvo
        public static void obrisiOstrvo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo lokacija = s.Load<Ostrvo>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }

        public static List<LokacijaView> VratiSveLokacije()
        {
            List<LokacijaView> odInfos = new List<LokacijaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lokacija> lokacije = from o in s.Query<Lokacija>()
                                                 select o;

                foreach (Lokacija o in lokacije)
                {
                    odInfos.Add(new LokacijaView(o));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }
        public static OstrvoView vratiOstrvo(int Id)
        {
            OstrvoView lokacija = new OstrvoView();
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo lokacija1 = s.Load<Ostrvo>(Id);
                lokacija = new OstrvoView(lokacija1);

               
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacija;
        }
        public static void izmeniOstrvo(OstrvoView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               Ostrvo o = s.Load<Ostrvo>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(o.Borio_se);
                o.Borio_se = p;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void dodajOstrvo(OstrvoView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo o = new Ostrvo();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(o.Borio_se);
                o.Borio_se = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Ostrvo

        #region Piramida
        public static void obrisiPiramidu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Piramida lokacija = s.Load<Piramida>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }

       
        public static PiramidaView vratiPiramidu(int Id)
        {
            PiramidaView lokacija = new PiramidaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Piramida lokacija1 = s.Load<Piramida>(Id);
                lokacija = new PiramidaView(lokacija1);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacija;
        }
        public static void izmeniPiramidu(PiramidaView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Piramida o = s.Load<Piramida>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void dodajPiramidu(OstrvoView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ostrvo o = new Ostrvo();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion Piramida

        #region GradDuhova

        public static void obrisiGradDuhova(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova lokacija = s.Load<Grad_duhova>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static GradDuhovaView vratiGradDuhova(int id)
        {
            GradDuhovaView lokacija = new GradDuhovaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova lokacija1 = s.Load<Grad_duhova>(id);
                lokacija = new GradDuhovaView(lokacija1);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacija;

        }


        public static void izmeniGradDuhova(GradDuhovaView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova o = s.Load<Grad_duhova>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(o.Borio_se);
                o.Borio_se = p;




                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajGradDuhova(GradDuhovaView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad_duhova o = new Grad_duhova();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion GradDuhova

        #region UkletiZamak

        public static void obrisiUkletiZamak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ukleti_zamak lokacija = s.Load<Ukleti_zamak>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static UkletiZamakView vratiUkletiZamak(int id)
        {
            UkletiZamakView lokacija = new UkletiZamakView();
            try
            {
                ISession s = DataLayer.GetSession();

                Ukleti_zamak lokacija1 = s.Load<Ukleti_zamak>(id);
                lokacija = new UkletiZamakView(lokacija1);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacija;

        }


        public static void izmeniUkletiZamak(UkletiZamakView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ukleti_zamak o = s.Load<Ukleti_zamak>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajUkletiZamak(UkletiZamakView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               Ukleti_zamak o = new Ukleti_zamak();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion UkletiZamak
        #region Pecina

        public static void obrisiPecinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina lokacija = s.Load<Pecina>(id);

                s.Delete(lokacija);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static PecinaView vratiPecina(int id)
        {
            PecinaView lokacija = new PecinaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina lokacija1 = s.Load<Pecina>(id);
                lokacija = new PecinaView(lokacija1);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacija;

        }

       
        public static void izmeniPecina(PecinaView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina o = s.Load<Pecina>(lokacija.ID);

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void sacuvajPecina(PecinaView lokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pecina o = new Pecina();

                o.ID = lokacija.ID;
                o.Naziv_lokacije = lokacija.Naziv_lokacije;
                o.Tip_lokacije = lokacija.Tip_lokacije;
                o.Zemlja = lokacija.Zemlja;
                o.Blago = lokacija.Blago;
                Predstavnik p = s.Load<Predstavnik>(lokacija.Borio_se);
                o.Borio_se = p;

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion Pecina
        #region Predstavnik
        //----!!neki eror baca kad se buil vidi sta je------
      /*  public static List<PredmetView> vratiSvePredstavnike()
        {
            List<PredmetView> predstavnici = new List<PredmetView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavnik> sviPredstavnici = from o in s.Query<Predstavnik>()
                                                                              select o;

                foreach (Predstavnik p in sviPredstavnici)
                {
                    predstavnici.Add(new PredmetView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predstavnici;
        }*/

        public static void dodajPredstavnika(PredstavnikView o)
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
                p.Id_cudovista = s.Load<Cudoviste>(o.Id_cudovista);
                p.Id_lokacije = s.Load<Lokacija>(o.Id_lokacije);
                s.SaveOrUpdate(o);

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
                p.Id_cudovista = s.Load<Cudoviste>(o.Id_cudovista);
                p.Id_lokacije = s.Load<Lokacija>(o.Id_lokacije);

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return o;
        }

        public static PredstavnikView vratiPredstavnika(int id)
        {
            PredstavnikView pb = new PredstavnikView();
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnik p = s.Load<Predstavnik>(id);
                pb = new PredstavnikView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
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
    }
}
