using System;

class Program
{
  static void Main()
  {
    char[] letters = {'x', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
    Console.WriteLine("Enter the queen's coordinates: ");
    string queen = Console.ReadLine();
    Console.WriteLine("Enter the other chess piece's coordinates: ");
    string other = Console.ReadLine();
    
    if(queen[0] == other[0] || queen[1] == other[1]) {
      Console.WriteLine("You can attack!");
    } else if(Math.Abs(Array.IndexOf(letters, queen[0]) + queen[1]) == Math.Abs(Array.IndexOf(letters, other[0]) + other[1])) {
      Console.WriteLine("You can attack!");
    } else if(Math.Abs(Array.IndexOf(letters, queen[0]) - queen[1]) == Math.Abs(Array.IndexOf(letters, other[0]) - other[1])) {
      Console.WriteLine("You can attack!");
    } else {
      Console.WriteLine("You can NOT attack!");
    }
  }
}
