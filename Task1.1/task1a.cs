using System;

class Program {
    static void Main(string[] args) {
      double number = Convert.ToDouble(Console.ReadLine());
      if(number%3==0 && number%7==0)
        Console.WriteLine("Divided");
      else
        Console.WriteLine("Not divided");
    }
}