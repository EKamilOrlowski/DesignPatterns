using DesignPatternsApp.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Factory_Method
{
    public class Ship : ITransport
    {
        public string Delivery()
        {
            return "Delivery by sea in a container.";
        }
    }
}
