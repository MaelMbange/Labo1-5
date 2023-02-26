namespace LbFormes;

public class Carre : Forme,ISommet,IEstDans
{
    private float _lenght;
    public float Lenght { get => Lenght; set => _lenght = value; }

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
    public bool CoordonneeEstDans(Coordonnees p)
    {
        if (_coordonnees.X <= p.X && p.X <= _coordonnees.X + _lenght)
            return _coordonnees.Y <= p.Y && p.Y <= _coordonnees.Y + _lenght;
        return false;
    }
    

}