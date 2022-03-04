using System;
 
class program2 {
  static void smallest(int x, int y, int z) {
    int min = x;
    if (x <= y && x <= z)
      min = x;
    if (y <= x && y <= z)
      min = y;
    if (z <= x && z <= y)
      min = z;
    Console.WriteLine(min);
  }  

  static void Main(string[] args) {
      int x = Convert.ToInt32(Console.ReadLine());
      int y = Convert.ToInt32(Console.ReadLine());
      int z = Convert.ToInt32(Console.ReadLine());
    smallest(x, y, z);
  }
}   