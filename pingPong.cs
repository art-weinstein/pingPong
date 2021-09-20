using System;
using System.Collections.Generic;

class pingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);

    for (int i = 1; i<=yourNumber; i++){
    if (i % 3 == 0 && i % 5 == 0) {
      Console.WriteLine("Ping Pong");
    } else if (i % 5 == 0) {
      Console.WriteLine("Pong");
    } else if (i % 3 == 0) {
      Console.WriteLine("Ping");
    } else {
      Console.WriteLine(i);
    }





    // for (int i = 0; i < yourNumber; i++)
    // {
    //   if (yourNumber % 3 == 0) {
    //     Console.WriteLine("Ping");
    //   } else {
    //     yourNumber += i;
    //     Console.WriteLine(yourNumber);
    //   }
    // }
    // Console.WriteLine(i);
    }
  }
}
