namespace Test.Shared.Domain
{
    using System;

    public static class UuidMother
    {
        public static string Random()
        {
            return new Guid().ToString();
        }
    }
}