namespace Santa
{
    public class Child
    {
        public Child(string name, string location, string gift, Disposition disposition)
        {
            Name = name;
            Location = location;
            Gift = gift;
            Disposition = disposition;
        }

        public string Name { get; }
        public string Location { get; }
        public string Gift { get; }
        public Disposition Disposition { get; }
    }
}