namespace LbFormes;

public class Carre : Forme,ISommet,IEstDans
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
    public int NbSommet => 4;
    public bool CoordonneeEstDans(Coordonnees coordonnees)
    {
        if (_coordonnees.X <= coordonnees.X && coordonnees.X <= _coordonnees.X + _lenght)
            return _coordonnees.Y <= coordonnees.Y && coordonnees.Y <= _coordonnees.Y + _lenght;
        return false;
    }
    

}