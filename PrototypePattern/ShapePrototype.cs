namespace PrototypePattern
{
    public abstract class ShapePrototype
    {
        protected ShapePrototype(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public string Type { get; protected set; }

        public abstract void Draw();
        public abstract ShapePrototype Clone();
    }
}