using DesignPatternsApp.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Factory_Method
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
