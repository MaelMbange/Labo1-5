using LbFormes;

namespace Labo1
{
    internal class Program
    {
        public static void Main(String[] argv)
        {
            Coordonnees coordonnees = new Coordonnees(5, 5);
            Coordonnees coordonnees1 = new Coordonnees(11, 11);

            Carre c = new Carre(10, 0, 0);
            Console.WriteLine("Carre:");
            Console.WriteLine(c);
            Console.WriteLine(c.NbSommet);
            Console.WriteLine(c.CoordonneeEstDans(coordonnees));
            Console.WriteLine(c.CoordonneeEstDans(coordonnees1));
            Console.WriteLine("===============================");
            
            
            Cercle r = new Cercle(10, 0, 0);
            Console.WriteLine("Cercle:");
            Console.WriteLine(r);
            Console.WriteLine(r.CoordonneeEstDans(coordonnees));
            Console.WriteLine(r.CoordonneeEstDans(coordonnees1));
            Console.WriteLine("===============================");

            Rectange t = new Rectange(10, 10, 0, 0);
            Console.WriteLine("Rectangle:");
            Console.WriteLine(t);
            Console.WriteLine(t.NbSommet);
            Console.WriteLine(t.CoordonneeEstDans(coordonnees));
            Console.WriteLine(t.CoordonneeEstDans(coordonnees1));
        }
    }
}

