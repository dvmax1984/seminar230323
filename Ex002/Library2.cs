public static class Method
{
  public static double GetDegree(double a, double b)
  {
    if (b < 0) return 1 / (GetDegree(a, b+1) * a);
    else return b == 0 ? 1 : GetDegree(a, b-1) * a;
  }
}