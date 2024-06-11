// Una palabra es palíndromo cuando al voltearla sigue diciendo lo mismo.
// hola != aloh -> no es palídromo
// reconocer == reconocer -> es palíndromo

Console.WriteLine("Agrega la palabra para saber si es o no palíndromo");
string text = Console.ReadLine();
isPalindrome(text.ToString());
void isPalindrome(string text)
{
    string reversetext = reverseText(text);
    if (text == reversetext)
    {
        Console.WriteLine($"{text} es palíndromo -> {text} == {reversetext}");
    }
    Console.WriteLine($"{text} no es palíndromo -> {text} == {reversetext}");
}

string reverseText(string text) {
    if (text.Length == 0) return "";
    string reversetext = new string(text.Reverse().ToArray());
    return reversetext;
}
