namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class Product
    {
        private List<object> _parts = new();
        public List<object> Parts => _parts;

        public void Add(object part)
        {
            _parts.Add(part);
        }

        public override string? ToString()
        {
            return $"Product parts: {string.Join(", ", _parts)}\n";
        }
    }
}
