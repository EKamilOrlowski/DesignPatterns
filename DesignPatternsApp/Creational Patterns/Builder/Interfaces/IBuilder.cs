namespace DesignPatternsApp.Creational_Patterns.Builder.Interfaces
{
    public interface IBuilder
    {
        void BuildPartA(object partA);

        void BuildPartB(object partA);

        void BuildPartC(object partA);
    }
}
