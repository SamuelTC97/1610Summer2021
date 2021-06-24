using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
	int i=1;
	while (i<6)
	{
		Console.WriteLine(i);
		i++;
	}
}
{
	int i = 1;
	do
	{
		Console.WriteLine(i);
		i++;
	}
	while (i < 6);
}
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine("Yes");
	}
}
{
	for (int i = 0; i < 10; i++)
	{
		if (i == 5)
		{
			break;
		}
		Console.WriteLine(i);
	}
}
{
	for (int i = 0; i < 7; i++)
	{
		if (i == 4)
		{
			continue;
		}
		Console.WriteLine(i);
	}
}
