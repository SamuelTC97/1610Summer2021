using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C#Arrays : MonoBehaviour
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
}
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Console.WriteLine(cars[1]);
}
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    cars[0] = "Opel";
    Console.WriteLine(cars[0]);
}
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars)
    {
        Console.WriteLine(i);
    }    
}
{
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    Arrays.Sort(cars);
    foreach (string i in cars)
    {
        Console.WriteLine(i);
    }    
}