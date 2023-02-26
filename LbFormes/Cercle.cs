namespace LbFormes;

public class Cercle : Forme,IEstDans
{
    private float _rayon;
    public float Rayon { get => _rayon; set => _rayon = value; }

    public Cercle() : this(0,0,0){}
    public Cercle(float rayon, int x, int y) => (_rayon, _coordonnees.X, _coordonnees.Y) = (rayon, x, y);

    
    public override void Affiche()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString() => _coordonnees.X + " : " + _coordonnees.Y + " | ray = " + _rayon;
    public bool CoordonneeEstDans(Coordonnees p)
    {
        double distanceAuCentre = Math.Sqrt(Math.Pow(p.X - _coordonnees.X, 2) + Math.Pow(p.Y - _coordonnees.Y, 2));
        return distanceAuCentre <= _rayon;
    }
}