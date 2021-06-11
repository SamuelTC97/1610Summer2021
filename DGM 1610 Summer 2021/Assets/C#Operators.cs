using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C#Operators : MonoBehaviour
{
    int x = 4;
    x++;
    Console.WriteLine(x);
    {
        int x = 5;
        int y = 10;
        Console.WriteLine(x + y);
    }
    {
        int x = 11;
        int y = 3;
        Console.WriteLine(x * y);
    }
    {
        int x = 10;
        x += 5;
        Console.WriteLine(x);
    }
    {
        int x = 4;
        int y == x;
        Console.WriteLine(x);
    }
    {
        int x = 34;
        Console.WriteLine(x < 35 && x > 33);
    }
}
