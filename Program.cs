using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figura ----------------------------------------------------");
            // For class Figura
            Console.WriteLine("Podaj wspolrzedna X");
            int x_in = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna Y");
            int y_in = Int32.Parse(Console.ReadLine());
            Figura f1 = new Figura(x_in, y_in);
            f1.Wyswietl();

            Console.WriteLine("\nProstokat : Figura ----------------------------------------");
            // For class Prostokat : Figura
            Console.WriteLine("Podaj szerokosc");
            int sze_in = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc");
            int wys_in = Int32.Parse(Console.ReadLine());
            Prostokat f2 = new Prostokat(x_in, y_in, sze_in, wys_in);
            f2.Wyswietl();

            Console.WriteLine("\nKwadrat : Prostokat ---------------------------------------");
            // For class Kwadrat : Prostokat
            Kwadrat f3 = new Kwadrat(x_in, y_in, sze_in);
            f3.Wyswietl();

            Console.WriteLine("\nKolo : Kwadrat ---------------------------------------");
            Kolo f4 = new Kolo(x_in, y_in, sze_in);
            f4.Wyswietl();
            // Console
            Console.ReadKey();
        }
        // Cw 15
        public class Figura
        {
            public int X;
            public int Y;
            public Figura(int x_input, int y_input)
            {
                X = x_input;
                Y = y_input;
            }
            public virtual void Wyswietl()
            {
                Console.WriteLine("\nWspolrzedna X: {0}\nWspolrzedna Y: {1}", X, Y);
            }
            public virtual int Pole()
            {
                return 0;
            }
        }
        // Cw 16
        public class Prostokat : Figura
        { 
            public int szerokosc;
            public int wysokosc;

            public Prostokat(int x_figura, int y_figura, int sze, int wys) : base(x_figura, y_figura)
            {
                szerokosc = sze;
                wysokosc = wys;
            }
            public override int Pole()
            {
                return szerokosc * wysokosc;
            }
            public override void Wyswietl()
            {
                base.Wyswietl();
                Console.WriteLine("\nSzerokosc prostokata: {0}, wysokosc prostokata: {1}, pole: {2}", szerokosc, wysokosc, Pole());
            } 
        }
        // Cw 17
        public class Kwadrat : Prostokat
        {

            public Kwadrat(int x_figura, int y_figura, int bok) : base(x_figura, y_figura, bok, bok)
            {
            }

            public override void Wyswietl()
            {
                Console.WriteLine("\nWspolrzedna X: {0}\nWspolrzedna Y: {1}", X, Y);
                Console.WriteLine("\nDlugosc boku kwadratu wynosi: {0}, pole: {1}", szerokosc, Pole());
            }
        }
        // Cw 18
        public class Kolo : Kwadrat
        {
            public Kolo(int x_figura, int y_figura, int promien) : base(x_figura, y_figura, promien)
            {
            }
            public override int Pole()
            {
                {
                    return Convert.ToInt32(2 * Math.PI * szerokosc * szerokosc);
                }
            }
            public override void Wyswietl()
            {
                Console.WriteLine("\nWspolrzedna X: {0}\nWspolrzedna Y: {1}", X, Y);
                Console.WriteLine("\nPromien kola wynosi: {0}, pole: {1}", szerokosc, Pole());
            }
        }
    }
}
