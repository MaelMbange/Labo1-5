namespace LbFormes;

public class Coordonnees
{
    private int _x;
    private int _y;

    public int X { get; set; }
    public int Y { get; set; }

    public Coordonnees(): this(0, 0){}

    public Coordonnees(int X, int Y)
    {
        _x = X;
        _y = Y;
    }

}