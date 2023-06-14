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
    }
}
