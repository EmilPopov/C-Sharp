//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;


namespace GravitationOnTheMoon
{
    class MoonGravitation
    {
        static void Main()
        {
            Console.Write("Enter your kg:");
            double kg = double.Parse(Console.ReadLine());
            double moonGravitation = 0.17;
            double moonKg = kg * moonGravitation;
            Console.WriteLine("On the Moon your weight will be {0}", moonKg);
        }
    }
}
