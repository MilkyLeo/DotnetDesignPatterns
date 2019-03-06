namespace FacadePattern
{
    /// <summary>
    /// Patron of restaurant
    /// </summary>

    public class Patron
    {
        public Patron(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}