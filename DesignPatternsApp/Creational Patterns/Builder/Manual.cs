using System.Text;

namespace DesignPatternsApp.Creational_Patterns.Builder
{
    public class Manual
    {
        private List<object> _chapters = new();
        public List<object> Chapters => _chapters;

        public void Add(object chapter)
        {
            _chapters.Add(chapter);
        }

        public override string? ToString()
        {
            StringBuilder manual = new();
            for (int i = 0; i < _chapters.Count; i++)
                manual.AppendLine($"{i + 1}. {_chapters[i]}");

            return $"Manual:\n {manual}";
        }
    }
}
