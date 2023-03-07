namespace LbFormes;

public class Coordonnees
{
    private int _x;
    private int _y;

    public int X { get => _x; set => _x = value; }
    public int Y { get => _y; set => _y = value; }

    public Coordonnees(): this(0, 0){}

    public Coordonnees(int X, int Y)
    {
        _x = X;
        _y = Y;
    }

}