using LbFormes;

namespace Labo1
{
    internal class Program
    {
        public static void Main(String[] argv)
        {
            //Test1();
            //Test2();
            //Test3();
            Test4();
        }

        public static void Test1()
        {
            Cercle c1 = new Cercle(1,0,0);
            Cercle c2 = new Cercle(2,0,0);

            Carre ca1 = new Carre(1,0,0);
            Carre ca2 = new Carre(2,0,0);

            System.Drawing.Rectangle r1 = new System.Drawing.Rectangle(1,1,0,0);
            System.Drawing.Rectangle r2 = new System.Drawing.Rectangle(2,2,0,0);

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
            
            Carre ca1 = new Carre(1,0,0);
            Carre ca2 = new Carre(2,1,0);
            
            Console.WriteLine(fac.Compare(ca1,ca2));
        }
    }
}

