using LbFormes;
using LMathUtil;

namespace Labo1
{
    internal class Program
    {
        public static void Main(String[] argv)
        {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            Test5();
        }

        public static void Test1()
        {
            Cercle c1 = new Cercle(1,0,0);
            Cercle c2 = new Cercle(2,0,0);

            Carre ca1 = new Carre(1,0,0);
            Carre ca2 = new Carre(2,0,0);

            Rectangle r1 = new Rectangle(1,1,0,0);
            Rectangle r2 = new Rectangle(2,2,0,0);

            Coordonnees cd1 = new Coordonnees(1, 1);
            Coordonnees cd2 = new Coordonnees(3, 3);
            
            Console.WriteLine(c1.CoordonneeEstDans(cd1));
            Console.WriteLine(c2.CoordonneeEstDans(cd1));
            ca1.Affiche();

        }

        public static void Test2()
        {
            List<Forme> formeList = new List<Forme>();
            
            Cercle c1 = new Cercle(1,0,0);
            Cercle c2 = new Cercle(2,0,0);

            Carre ca1 = new Carre(1,0,0);
            Carre ca2 = new Carre(2,0,0);

            Rectangle r1 = new Rectangle(1,1,0,0);
            Rectangle r2 = new Rectangle(2,2,0,0);

            formeList.Add(c1);
            formeList.Add(c2);
            formeList.Add(ca1);
            formeList.Add(ca2);
            formeList.Add(r1);
            formeList.Add(r2);

            Console.WriteLine("Affichage de la liste :");
            foreach (Forme f in formeList)
            {
                f.Affiche();
            }
            Console.WriteLine("=========================\n");
            
            Console.WriteLine("Affichage de la liste ISommet:");
            foreach (Forme f in formeList.Where(x => x is ISommet))
            {
                f.Affiche();
            }
            Console.WriteLine("=========================\n");
            
            Console.WriteLine("Affichage de la liste PAS ISommet:");
            foreach (Forme f in formeList.Where(x => x is not ISommet))
            {
                f.Affiche();
            }
            Console.WriteLine("=========================\n");

        }

        public static void Test3()
        {
            List<Carre> list = new List<Carre>();
            
            list.Add(new Carre(4,0,0));
            list.Add(new Carre(1,0,0));
            list.Add(new Carre(2,0,0));
            list.Add(new Carre(5,0,0));
            list.Add(new Carre(3,0,0));
            
            list.Sort();

            list.ForEach(x => Console.WriteLine(x.ToString()));
        }

        public static void Test4()
        {
            FormeAbssiceComparer fac = new FormeAbssiceComparer();

            List<Carre> list = new List<Carre>();
            Carre c = new Carre(1, 1, 0);
            
            list.Add(new Carre(4,1,0));
            list.Add(new Carre(1,0,1));
            list.Add(new Carre(2,1,1));
            list.Add(new Carre(1,0,2));
            list.Add(new Carre(3,2,0));
            
            list.Sort(fac);

            list.ForEach(x => Console.WriteLine(x.ToString()));
            List<Carre> list2 = list.FindAll(ca => (int)ca.Lenght == (int)c.Lenght);
            Console.WriteLine("\nFindAll\n=============");
            list2.ForEach(x=> Console.WriteLine(x));
        }

        public static void Test5()
        {
            List<Forme> formeList = new List<Forme>();
            
            Cercle c1 = new Cercle(1,0,1);
            Cercle c2 = new Cercle(2,1,0);

            Carre ca1 = new Carre(1,1,1);
            Carre ca2 = new Carre(2,0,0);

            Rectangle r1 = new Rectangle(1,1,2,0);
            Rectangle r2 = new Rectangle(2,2,1,0);

            formeList.Add(c1);
            formeList.Add(c2);
            formeList.Add(ca1);
            formeList.Add(ca2);
            formeList.Add(r1);
            formeList.Add(r2);

            Coordonnees co = new Coordonnees(1, 0);
            
            formeList.OfType<IEstDans>().Where(f => f.CoordonneeEstDans(co)).ToList().ForEach(Console.WriteLine);
            
            Console.WriteLine("Triage par surface");
            formeList.Sort(new FormeSurfaceComparer());
            formeList.ForEach( x => Console.WriteLine(x + " => surface = " + MathUtil.GetSurface(x)));
        }
    }
}

