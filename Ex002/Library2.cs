public static class Method
{
  public static double GetDegree(double a, double b)
  {
    if (b < 0) return 1 / (GetDegree(a, b*-1));
    else if (b > 0) return GetDegree(a, b-1) * a;
    else return 1;
  }
  
  public static int GetResult(int a)
  {
    if (a == 0) return 0;
    else return a % 10 + GetResult(a/10);
  }
  
  
}