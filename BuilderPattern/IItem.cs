namespace BuilderPattern
{
    public interface IItem
    {
        string Name { get; }
        IPacking Packing();
        float Price();
    }
}