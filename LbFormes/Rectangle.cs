namespace LbFormes;

public class Rectangle : Forme,ISommet,IEstDans
{
    private float _largeur;
    private float _longueur;

    public float Longueur { get => _longueur; set => _longueur = value; }
    public float Largeur { get => _largeur; set => _largeur = value; }


    public Rectangle() : this(0, 0, 0, 0){}
    public Rectangle(float largeur, float longueur, int x, int y) : base(x,y) => (Largeur,Longueur) = (largeur,longueur);
    
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