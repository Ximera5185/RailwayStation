using System;

namespace RailwayStation
{
    internal class UserUtils
    {
        public static int GenerateRandomNumber(int min, int max) 
        {
            return  new Random().Next(min, max);
        }
    }
}