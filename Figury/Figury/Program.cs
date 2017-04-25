using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wspolrzedna x punktu zaczepienia: ");
            string first = Console.ReadLine();
            int x1 = Convert.ToInt32(first);
            Console.WriteLine("Podaj wspolrzedna y punktu zaczepienia: ");
            string sec = Console.ReadLine();
            int y1 = Convert.ToInt32(sec);
            Console.WriteLine("Podaj dlugosc dluzszego boku: ");
            string dluzszy = Console.ReadLine();
            int bokdl = Convert.ToInt32(dluzszy);
            Console.WriteLine("Podaj dlugosc krotszego boku: ");
            string krotszy = Console.ReadLine();
            int bokkr = Convert.ToInt32(dluzszy);
            prostokat(x1, y1, bokdl, bokkr);

            Console.ReadKey();
        }


        

        static public void prostokat(int x, int y, int bok1, int bok)
        {

            int drugax = x + bok1;
            int drugay = y + bok;
            Console.WriteLine("(" + x + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + drugay + ")");
            Console.WriteLine("(" + x + "," + drugay + ")");
        }
        static public void trojkat(int x, int y, int podstawa, int h)
        {

            int drugax = x + podstawa;
            int trzeciax = x + podstawa / 2;
            int trzeciay = y + h;
            Console.WriteLine("(" + x + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + y + ")");
            Console.WriteLine("(" + trzeciax + "," + trzeciay + ")");

        }
    
}
}
