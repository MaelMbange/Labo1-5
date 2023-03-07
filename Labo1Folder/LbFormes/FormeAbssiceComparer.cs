namespace LbFormes;

public class FormeAbssiceComparer : IComparer<Forme>
{
    public int Compare(Forme? x, Forme? y)
    {
        if(x is not null && y is not null)
            if(x.Coordonnees.X == y.Coordonnees.X)
                if (x.Coordonnees.Y == y.Coordonnees.Y)
                    return 0;
                else if (x.Coordonnees.Y < y.Coordonnees.Y) return -1;
                else return 1;
            else if (x.Coordonnees.X < y.Coordonnees.X)
                    return -1;
            else return 1;
        throw new Exception("Object reference is null");
    }
}