namespace Shared.Infrastructure
{
    using System;
    using Domain;

    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int Generate()
        {
            Random random = new Random();  
            return random.Next(1, 5);  
        }
    }
}