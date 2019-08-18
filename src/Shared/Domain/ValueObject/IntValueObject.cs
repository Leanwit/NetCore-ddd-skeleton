namespace src.Shared.Domain.ValueObject
{
    public abstract class IntValueObject
    {
        public int Value { get; private set; }

        public IntValueObject(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}