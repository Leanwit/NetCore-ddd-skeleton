namespace Shared.Domain.ValueObject
{
    using System;
    using System.ComponentModel;

    public class Uuid
    {
        private string Value { get; set; }

        public Uuid(string value)
        {
            this.EnsureIsValidUuid(value);
            Value = value;
        }

        private void EnsureIsValidUuid(string value)
        {
            if (!Guid.TryParse(value, out var Uuid))
            {
                throw new InvalidEnumArgumentException($"{value} is not a valid GUID");
            }
        }

        public override string ToString()
        {
            return this.Value;
        }
        
        public static Uuid Random()
        {
            return new Uuid(Guid.NewGuid().ToString());
        }
    }
}