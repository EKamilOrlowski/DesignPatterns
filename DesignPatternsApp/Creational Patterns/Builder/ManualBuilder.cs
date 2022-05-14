using DesignPatternsApp.Creational_Patterns.Builder.Interfaces;

namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class ManualBuilder : IBuilder
    {
        private Manual _manual = new();

        public ManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        public void BuildPartA(object partA)
        {
            _manual.Add(PartToString(partA));
        }

        public void BuildPartB(object partB)
        {
            _manual.Add(PartToString(partB));
        }

        public void BuildPartC(object partC)
        {
            _manual.Add(PartToString(partC));
        }

        public Manual GetManual()
        {
            Manual result = _manual;

            Reset();

            return result;
        }

        private string PartToString(object part)
        {
            return $"Chapter{part}";
        }
    }
}
