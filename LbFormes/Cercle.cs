namespace LbFormes;

public class Cercle : Forme
{
    private float _rayon;
    public float Rayon { get; set; }

    public Cercle() : this(0,0,0){}
    public Cercle(float rayon, int x, int y) => (_rayon, _coordonnees.X, _coordonnees.Y) = (rayon, x, y);

    
    public override void Affiche()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString() => _coordonnees.X + " : " + _coordonnees.Y + " | ray = " + _rayon;
}