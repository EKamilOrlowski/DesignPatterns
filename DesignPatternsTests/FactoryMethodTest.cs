using DesignPatternsApp.Creational_Patterns.Factory_Method;

namespace DesignPatternsTests
{
    public class FactoryMethodTest
    {
        [Theory]
        [InlineData(100, "Delivery by land in a box.")]
        [InlineData(15, "Delivery by land in a box.")]
        [InlineData(550, "Delivery by sea in a container.")]
        public void DeliveryTest(uint distnace, string correntResult)
        {
            string bestDelivery = Application.GetBestDelivery(distnace);
            Assert.Equal(bestDelivery, correntResult);
        }
    }
}
