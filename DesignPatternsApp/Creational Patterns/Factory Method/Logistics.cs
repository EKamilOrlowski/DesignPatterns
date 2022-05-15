using DesignPatternsApp.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Factory_Method
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public string SomeDelivery()
        {
            var transport = CreateTransport();
            return transport.Delivery();
        }
    }
}
