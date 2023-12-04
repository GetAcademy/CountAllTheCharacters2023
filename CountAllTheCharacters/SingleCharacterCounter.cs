namespace CountAllTheCharacters
{
    internal class SingleCharacterCounter
    {
        private char _character;
        private int _count;

        public bool IsMatch(char character)
        {
            return _character == character;
        }

        public void Count()
        {
            _count++;
        }

        public string GetCounts()
        {
            if (_count == 0) return "";
            return _character + " - " + _count;
        } 
    }
}
