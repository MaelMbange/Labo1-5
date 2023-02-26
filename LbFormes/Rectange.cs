namespace LbFormes;

public class Rectange : Forme
{
    private float _largeur;
    private float _longueur;

    public float Longeur { get; set; }
    public float Largeur { get; set; }


    public Rectange() : this(0, 0, 0, 0){}
    public Rectange(float largeur, float longueur, int x, int y) =>
        (_longueur, _largeur, _coordonnees.X, _coordonnees.Y) = (longueur, largeur, x, y);
    
    public override void Affiche()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString() => _coordonnees.X + " : " + _coordonnees.Y + " | lenght = " + _longueur + " | width = "+ _largeur;
}