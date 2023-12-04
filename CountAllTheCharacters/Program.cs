using CountAllTheCharacters;

var charCounter = new CharactersCounter();
var text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    charCounter.Count(text);
    var stats = charCounter.Show();
    Console.WriteLine(stats);
}



