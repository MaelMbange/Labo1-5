namespace LMathUtil;
using LbFormes;

public class MathUtil
{
    public static float GetSurface(Forme f)
    {
        if (f is Carre ca)
            return ca.Lenght * 4;
        if (f is Rectangle rec)
            return 2 * (rec.Longueur + rec.Largeur);
        if (f is Cercle ce)
            return (float)(3.14 * ce.Rayon * 2);
        else
            return 0;
    }

    public static bool IsBetween(float value, float min, float max) => value <= max && min <= value;
}