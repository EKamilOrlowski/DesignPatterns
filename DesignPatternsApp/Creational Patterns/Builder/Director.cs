using DesignPatternsApp.Creational_Patterns.Builder.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViable()
        {
            _builder.BuildPartA("A");
        }

        public void BuildFullFeatured()
        {
            _builder.BuildPartA("A");
            _builder.BuildPartB("B");
            _builder.BuildPartC("C");
        }
    }
}
