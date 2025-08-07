namespace Core
{
    public class Element(string name, string symbol, int number)
    {
        public string Symbol => symbol;

        public string Name => name;

        public int Number => number;

        public override string ToString()
            => $"{Name} ({Symbol})";
    }
}
