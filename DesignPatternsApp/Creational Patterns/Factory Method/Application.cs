namespace DesignPatternsApp.Creational_Patterns.Factory_Method
{
    public class Application
    {
        public static string GetBestDelivery(uint distance)
        {
            if (distance > 500)
                return new SeaLogistics().SomeDelivery();
            return new RoadLogistics().SomeDelivery();
        }
    }
}
