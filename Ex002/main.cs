using System;
using static Library1;
using static Method;

class Program {
  public static void Main (string[] args) 
  {
    double a = GetNumber("Введите число A: ");
    double b = GetNumber("Введите число B степень числа А: ");

    Console.WriteLine(GetDegree(a, b));    
  }
}