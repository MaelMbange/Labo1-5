namespace LbFormes;

public class Carre : Forme
{
    private float _lenght;
    public float Lenght { get; set; }

    public Carre() : this(0, 0,0){}
    public Carre(float lenght, int x, int y) : base(x, y) => _lenght = lenght;
    public Carre(float lenght,Coordonnees coordonnees) : this(lenght,coordonnees.X,coordonnees.Y){}

    public override void Affiche()
    {
        Console.WriteLine(ToString());
    }
    public override string ToString()
    {
        return _coordonnees.X + " : " + _coordonnees.Y + " | lenght = " + _lenght;
    }
}