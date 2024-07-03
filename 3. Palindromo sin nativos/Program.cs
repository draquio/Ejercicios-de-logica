// Una palabra es palíndromo cuando al voltearla sigue diciendo lo mismo.
// hola != aloh -> no es palídromo
// reconocer == reconocer -> es palíndromo
// Este método es sin LINQ

using System.Text;

Console.WriteLine("Agrega la palabra para saber si es o no palíndromo");
string text = Console.ReadLine();
Console.WriteLine(isPalindrome(text.ToString()));

string isPalindrome(string text)
{
    string reverseText = ReverseText(text);
    if (text == reverseText)
    {
        return $"{text} es palíndromo {text} == {reverseText}";
    }
    return $"{text} no es palíndromo {text} != {reverseText}";
}

string ReverseText(string text)
{
    int length = text.Length;
    StringBuilder reverseText = new StringBuilder();
    for (int i = 1; i <= length; i++)
    {
        reverseText.Append(text[^i]);
    }
    return reverseText.ToString();
}