﻿using System;
class Program
{
    public static void Main()
    {
        for(int i = 1; i <= 20; i++)
        {
            if (i % 2==1)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}