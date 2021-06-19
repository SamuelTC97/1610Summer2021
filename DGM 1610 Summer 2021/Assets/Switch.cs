using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
   int day = 2;
   switch (day)
   {
      case 1:
          Console.Writeline("Monday"); 
          break;
      case 2:
          Console.Writeline("Tuesday");
          break;
   }
}

{
    int day = 3;
    switch (day)
    {
        case 1:
            Console.WriteLine("Today is Saturday");
            break;
        case 2:
            Console.WriteLine("Today is Sunday");
            break;
        default:
            Console.WriteLine("I am looking forward to the weekend");
            break;
    }
}