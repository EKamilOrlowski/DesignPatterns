using DesignPatternsApp.Creational_Patterns.Builder;

namespace DesignPatternsTests
{
    public class BuilderTest
    {
        [Fact]
        public void ProductMinimalViableTest()
        {
            Director director = new();
            ProductBuilder productBuilder = new();
            director.Builder = productBuilder;
            director.BuildMinimalViable();
            Product product = productBuilder.GetProduct();

            Assert.True(product?.Parts?.Count == 1);
            Assert.True(product?.Parts?.FirstOrDefault()?.ToString() == "PartA");
        }

        [Fact]
        public void ProductFullFeaturedTest()
        {
            Director director = new();
            ProductBuilder productBuilder = new();
            director.Builder = productBuilder;
            director.BuildFullFeatured();
            Product product = productBuilder.GetProduct();

            Assert.True(product?.Parts?.Count == 3);
            Assert.True(product?.Parts?.FirstOrDefault()?.ToString() == "PartA");
            Assert.True(product?.Parts?.Skip(1).FirstOrDefault()?.ToString() == "PartB");
            Assert.True(product?.Parts?.Skip(2).FirstOrDefault()?.ToString() == "PartC");
        }


        [Fact]
        public void ManualMinimalViableTest()
        {
            Director director = new();
            ManualBuilder manualBuilder = new();
            director.Builder = manualBuilder;
            director.BuildMinimalViable();
            Manual manual = manualBuilder.GetManual();

            Assert.True(manual?.Chapters?.Count == 1);
            Assert.True(manual?.Chapters?.FirstOrDefault()?.ToString() == "ChapterA");
        }

        [Fact]
        public void ManualFullFeaturedTest()
        {
            Director director = new();
            ManualBuilder manualBuilder = new();
            director.Builder = manualBuilder;
            director.BuildFullFeatured();
            Manual manual = manualBuilder.GetManual();

            Assert.True(manual?.Chapters?.Count == 3);
            Assert.True(manual?.Chapters?.FirstOrDefault()?.ToString() == "ChapterA");
            Assert.True(manual?.Chapters?.Skip(1).FirstOrDefault()?.ToString() == "ChapterB");
            Assert.True(manual?.Chapters?.Skip(2).FirstOrDefault()?.ToString() == "ChapterC");
        }
    }
}
