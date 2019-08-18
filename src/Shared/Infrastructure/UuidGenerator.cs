namespace Shared.Infrastructure
{
    using System;
    using Domain;

    public class SystemUuidGenerator : UuidGenerator
    {
        public string Generate()
        {
            return new Guid().ToString();
        }
    }
}