namespace LbFormes;

public abstract class Forme
{
    protected Coordonnees _coordonnees;

    public Forme()
    {
        _coordonnees = new Coordonnees();
    }

    protected Forme(Coordonnees coordonnees)
    {
        _coordonnees = coordonnees;
    }

    public abstract void Affiche();
}