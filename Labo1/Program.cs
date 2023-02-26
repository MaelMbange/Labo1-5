using LbFormes;

namespace Labo1
{
    internal class Program
    {
        public static void Main(String[] argv)
        {

            Carre c = new Carre(1, 0, 0);
            Console.WriteLine(c);
            
            Cercle r = new Cercle(2, 0, 0);
            Console.WriteLine(r);

            Rectange t = new Rectange(3, 3, 0, 0);
            Console.WriteLine(t);
        }
    }
}

