namespace Shared.Domain.ValueObject
{
    public abstract class StringValueObject
    {
        protected string Value { get; set; }

        public StringValueObject(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}