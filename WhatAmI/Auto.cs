using System;

namespace WhatAmI
{
    class Auto
    {
        float fuel;
        public Auto(float f, string color)
        {
            fuel = f;
            Console.WriteLine("the current fuel of my " + color+ " car is " + f);
        }
    }
}
