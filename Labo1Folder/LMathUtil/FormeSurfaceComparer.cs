using LbFormes;

namespace LMathUtil;

public class FormeSurfaceComparer : IComparer<Forme>
{
    public int Compare(Forme? x, Forme? y)
    {
        if(x is not null && y is not null)
            if (Math.Abs(MathUtil.GetSurface(x) - MathUtil.GetSurface(y)) < 2)
                return 0;
            else if (MathUtil.GetSurface(x) > MathUtil.GetSurface(y))
                return 1;
            else return -1;
        throw new Exception("Object reference is null");
    }
}