using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw0202
{
    public interface IBohater
    {
        void BijWroga();
        void SprawdzHp();
    }

    public abstract class Bohater : IBohater
    {
        public int hp;
        public int atak;
        public enum rasa 
        { kransolud, niziolek, elf, czlowiek }

        public abstract void BijWroga();
        public abstract void SprawdzHp();
    }

    public class Mag : Bohater
    {
        public int mana = 100;
        public bool czyMamMane = true;
        public void RzucCzar()
        {
            mana = mana - 20;
            if (mana < 20)
                Console.WriteLine("Mag: Czar nieudany");
            else
            {
                Console.WriteLine("Mag: Czar udany");
                czyMamMane = false;
            }
                
        }

        public override void BijWroga()
        {
            Console.WriteLine("Mag: Zadano {0} pkt obrażeń", atak);
            mana = mana + 10;
        }
        public override void SprawdzHp()
        {
            Console.WriteLine("Mag HP: {0}", hp);
        }
        public Mag(int hp, int atak)
        {
            this.hp = hp;
            this.atak = atak;
        }
        
    }

    public class Wojownik : Bohater
    {
        public void RzucToporem()
        {
            Console.WriteLine("Wojownik: Zadano rzutem {0} obrażeń", atak*2);
        }

        public override void BijWroga()
        {
            Console.WriteLine("Wojownik: Zadano {0} pkt obrażeń", atak);
        }
        public override void SprawdzHp()
        {
            Console.WriteLine("Wojownik HP: {0}", hp);
        }
        public Wojownik(int hp, int atak)
        {
            this.hp = hp;
            this.atak = atak;
        }
    }

    public class Rzezimieszek : Bohater
    {
        private int energia = 100;

        public override void BijWroga()
        {
            if (energia <= 0)
            {
                Console.WriteLine("Rzezimieszek odpoczywa");
                energia += 25;
            }
            else
            {
                Console.WriteLine("Rzezimieszek: Zadano {0} pkt obrażeń", atak);
                energia -= 10;
            }
        }
        public override void SprawdzHp()
        {
            Console.WriteLine("Rzezimieszek HP: {0}", hp);
        }
        public Rzezimieszek(int hp, int atak)
        {
            this.hp = hp;
            this.atak = atak;
        }
    }

    public class UrukHai : Bohater
    {
        public override void BijWroga()
        {
            Console.WriteLine("UrukHai: Zadano {0} pkt obrażeń", atak);
        }
        public override void SprawdzHp()
        {
            Console.WriteLine("UrukHai HP: {0}", hp);
        }
        public UrukHai(int hp, int atak)
        {
            this.hp = hp;
            this.atak = atak;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wojownik aragorn = new Wojownik(200, 10);
            Mag gandalf = new Mag(100, 5);
            Rzezimieszek frodo = new Rzezimieszek(75, 2);
            UrukHai urukHai = new UrukHai(400, 20);

            //do
            for (int i = 0; i < 100; i++)
            {
                if ((gandalf.hp < 0) && (aragorn.hp < 0) && (frodo.hp < 0))
                {
                    Console.WriteLine("Druzyna Piercienia PRZEGRALA :(");
                    break;
                }
                if (urukHai.hp<0)
                {
                    Console.WriteLine("Druzyna Pierscienia WYGRALA!!!");
                    break;
                }
                aragorn.BijWroga();
                urukHai.hp -= aragorn.atak;
                if (gandalf.czyMamMane)
                {
                    gandalf.RzucCzar();
                    urukHai.hp -= 20;
                }
                else
                {
                    gandalf.BijWroga();
                    urukHai.hp -= gandalf.atak;
                }
                frodo.BijWroga();
                urukHai.hp -= frodo.atak;

                if (aragorn.hp > gandalf.hp)
                {
                    Console.WriteLine("Uruk Hai atakuje Aragorna");
                    urukHai.BijWroga();
                    aragorn.hp -= urukHai.atak;
                }
                else if (gandalf.hp > frodo.hp)
                {
                    Console.WriteLine("Uruk Hai atakuje Gandalfa");
                    urukHai.BijWroga();
                    gandalf.hp -= urukHai.atak;
                }
                else
                {
                    Console.WriteLine("Uruk Hai atakuje Froda");
                    urukHai.BijWroga();
                    frodo.hp -= urukHai.atak;
                }
            }

            Console.ReadKey();
        }
    }
}
