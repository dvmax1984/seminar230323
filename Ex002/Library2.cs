public static class Method
{
  public static int GetDegree(int a, int b)
  {
      return b == 0 ? 1 : GetDegree(a, b-1) * a;      
  }
}