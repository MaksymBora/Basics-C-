﻿using System;

namespace ifElse;

internal class Program
{
    private static void Main(string[] args)
    {
        // bool isInfected = true;

        // if (isInfected)
        // {
        //     Console.WriteLine("Hero is infected");
        // }
        // else
        // {
        //     Console.WriteLine("Hero is healthy!");
        // }


        // ---------------------------------------------------------------- // 
        // Write a program that check is an entered number is even or not. //

        int value;

        Console.WriteLine("Enter a number >>>>> ");
        value = int.Parse(Console.ReadLine());

        var isEven = value % 2 == 0;

        if (isEven)
            Console.WriteLine("The number is even!");
        else
            Console.WriteLine("The number is not even!");
    }
}