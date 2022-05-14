using DesignPatternsApp.Creational_Patterns.Builder.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class ProductBuilder : IBuilder
    {
        private Product _product = new();

        public ProductBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA(object partA)
        {
            _product.Add(PartToString(partA));
        }

        public void BuildPartB(object partB)
        {
            _product.Add(PartToString(partB));
        }

        public void BuildPartC(object partC)
        {
            _product.Add(PartToString(partC));
        }

        public Product GetProduct()
        {
            Product result = _product;

            Reset();

            return result;
        }

        private string PartToString(object part)
        {
            return $"Part{part}";
        }
    }
}
