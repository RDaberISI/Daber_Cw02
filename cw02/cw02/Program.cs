using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw02
{
    public interface ISamochod
    {
        void WypiszMarke();
        void WypiszSalon();
    }

    public class AstonMartin: ISamochod
    {
        string marka = "Aston Martin";
        string salon = "Olsztyn";
        public void WypiszMarke()
        {
            Console.WriteLine("Wypisz marke : {0}", marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Wypisz salon : {0}", salon);
        }
    }

    public class RangeRover : ISamochod
    {
        string marka = "RangeRover";
        string salon = "Warszawa";
        public void WypiszMarke()
        {
            Console.WriteLine("Wypisz marke : {0}", marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Wypisz salon : {0}", salon);
        }
    }

    public class RollsRoyce : ISamochod
    {
        string marka = "RollsRoyce";
        string salon = "Krakow";
        public void WypiszMarke()
        {
            Console.WriteLine("Wypisz marke : {0}", marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine("Wypisz salon : {0}", salon);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            AstonMartin a1 = new AstonMartin();
            RangeRover a2 = new RangeRover();
            RollsRoyce a3 = new RollsRoyce();

            a1.WypiszMarke();
            a1.WypiszSalon();
            a2.WypiszMarke();
            a2.WypiszSalon();
            a3.WypiszMarke();
            a3.WypiszSalon();

            Console.ReadKey();
        }
    }
}
