using DesignPatternsApp.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Factory_Method
{
    public class Truck : ITransport
    {
        public string Delivery()
        {
            return "Delivery by land in a box.";
        }
    }
}
