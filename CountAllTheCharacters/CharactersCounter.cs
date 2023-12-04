using System.Text;

namespace CountAllTheCharacters
{
    internal class CharactersCounter
    {
        private readonly List<SingleCharacterCounter> _counters;

        public CharactersCounter()
        {
            _counters = new List<SingleCharacterCounter>();
        }

        public void Count(string s)
        {
            foreach (var character in s ?? string.Empty)
            {
                var counter = FindCounter(character);
                if (counter == null)
                {
                    counter = new SingleCharacterCounter();
                    _counters.Add(counter);
                }
                counter.Count();
            }
        }

        private SingleCharacterCounter? FindCounter(char character)
        {
            foreach (var counter in _counters)
            {
                if (counter.IsMatch(character)) return counter;
            }
            return null;
            //return _counters.SingleOrDefault(c=>c.IsMatch(character));
        }

        public string Show()
        {
            var text = new StringBuilder();
            foreach (var counter in _counters)
            {
                text.AppendLine(counter.GetCounts());
            }
            return text.ToString();
        }
    }
}
