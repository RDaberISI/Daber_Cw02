using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw0203
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public virtual Osoba(string imie_, string nazwisko_, string dataUrodzenia_);

        public virtual void WypiszInfo();
    }

    public class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_):base(imie_,nazwisko_,dataUrodzenia_)
        {
            this.rok = rok_;
            this.grupa = grupa_;
            this.nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Nazywam sie {0} {1} i jestem studentem", imie, nazwisko);
            Console.WriteLine("Data urodzenia: {0}", dataUrodzenia);
            Console.WriteLine("Rok: {0}, grupa: {1}, nr indeksu: {2}", rok, grupa, nrIndeksu);
        }

        //private Dictionary<string, List<double>> ocenyZPrzedmiotów = new Dictionary<string, List<double>>();

        //public void DodajOcene(double wartosc, string nazwaPrzedmiotu, string data)
        //{
        //    if (ocenyZPrzedmiotów.ContainsKey(nazwaPrzedmiotu))
        //        ocenyZPrzedmiotów[nazwaPrzedmiotu].Add(wartosc);
        //    else
        //    {
        //        ocenyZPrzedmiotów.Add(nazwaPrzedmiotu, new List<double>());
        //        ocenyZPrzedmiotów[nazwaPrzedmiotu].Add(wartosc);
        //    }
        //}

        List<Ocena> oceny = new List<Ocena>();
        public void DodajOcene(Ocena ocena)
        {
            oceny.Add(ocena);
        }

        //public void WypiszOceny()
        //{
        //    foreach (var przedmiot in ocenyZPrzedmiotów)
        //    {
        //        Console.WriteLine("Przedmiot: {0}", przedmiot.Key);
        //        foreach(var ocena in przedmiot.Value)
        //            Console.WriteLine(ocena);
        //    }
        //}

        public void WypiszOceny()
        {
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        //public void WypiszOceny(string nazwaPrzedmiotu)
        //{
        //    foreach (var przedmiot in ocenyZPrzedmiotów)
        //    {
        //        if (przedmiot.Key == nazwaPrzedmiotu)
        //        {
        //            Console.WriteLine("Wypisuje oceny z przedmiotu {0}:", przedmiot.Key);
        //            foreach (var ocena in przedmiot.Value)
        //                Console.WriteLine(ocena);
        //        }
        //    }
        //}

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (var ocena in oceny)
                if (ocena.nazwaPrzedmiotu == nazwaPrzedmiotu)
                    ocena.WypiszInfo();
        }

        //public void UsunOcene(string nazwaPrzemdiotu, string data, double wartosc)
        //{
        //    foreach (var przedmiot in ocenyZPrzedmiotów)
        //    {
        //        if (przedmiot.Key == nazwaPrzemdiotu)
        //        {
        //            for (int i = 0; i < przedmiot.Value.Count(); i++)
        //            {
        //                if (przedmiot.Value[i] == wartosc)
        //                    ocenyZPrzedmiotów[przedmiot.Key].Remove(przedmiot.Value[i]);
        //            }
        //        }
        //    }
        //}

        public void UsunOcene(Ocena ocena)
        {
            foreach (var ocenka in oceny)
                if (ocenka == ocena)
                    oceny.Remove(ocenka);
        }

        //public void UsunOceny()
        //{
        //    foreach (var przedmiot in ocenyZPrzedmiotów)
        //        ocenyZPrzedmiotów.Remove(przedmiot.Key);
        //}

        public void UsunOceny()
        {
            foreach (var ocena in oceny)
                oceny.Remove(ocena);
        }
        
        //public void UsunOceny(string nazwaPrzedmiotu)
        //{
        //    foreach (var przedmiot in ocenyZPrzedmiotów)
        //        if (przedmiot.Key == nazwaPrzedmiotu)
        //            ocenyZPrzedmiotów.Remove(przedmiot.Key);
        //}

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            foreach (var ocenka in oceny)
                if (ocenka.nazwaPrzedmiotu == nazwaPrzedmiotu)
                    oceny.Remove(ocenka);
        }
    }

    public class Ocena
    {
        public string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            this.data = data_;
            this.nazwaPrzedmiotu = nazwaPrzedmiotu_;
            this.wartosc = wartosc_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Przedmiot: {0}, data: {1}, wartosc {2}", this.nazwaPrzedmiotu, this.data, this.wartosc);
        }
    }

    public class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_)
            : base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.pozycja = pozycja_;
            this.klub = klub_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Pilkarz: {0} {1}, {2}, {3}, {4}", imie, nazwisko, dataUrodzenia, pozycja, klub);
        }

        public void StrzelGola()
        {
            liczbaGoli += 1;
        }
    }

    public class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_)
            : base(imie_, nazwisko_, dataUrodzenia_, pozycja_, klub_)
        {

        }
    }

    public class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_)
            : base(imie_, nazwisko_, dataUrodzenia_, pozycja_, klub_)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
