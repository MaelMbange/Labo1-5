namespace LbFormes;

public class Rectange : Forme,ISommet,IEstDans
{
    private float _largeur;
    private float _longueur;

    public float Longeur { get => _longueur; set => _longueur = value; }
    public float Largeur { get => _largeur; set => _largeur = value; }


    public Rectange() : this(0, 0, 0, 0){}
    public Rectange(float largeur, float longueur, int x, int y) =>
        (_longueur, _largeur, _coordonnees.X, _coordonnees.Y) = (longueur, largeur, x, y);
    
    public override void Affiche()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString() => _coordonnees.X + " : " + _coordonnees.Y + " | lenght = " + _longueur + " | width = "+ _largeur;


    public int NbSommet => 4;
    public bool CoordonneeEstDans(Coordonnees p)
    {
        if (_coordonnees.X <= p.X && p.X <= _coordonnees.X + _largeur)
            return _coordonnees.Y <= p.Y && p.Y <= _coordonnees.Y + _longueur;
        return false;
    }

}