// Escribe un programa que imprima los números del 1 al 100. Pero para los múltiplos de 3,
// imprime "Fizz" en lugar del número y para los múltiplos de 5, imprime "Buzz".
// Para los números que son múltiplos de ambos 3 y 5, imprime "FizzBuzz".

Console.WriteLine("Agrega el numero N hasta donde se realizará el FizzBuzz:");
string n = Console.ReadLine();
FizzBuzz(int.Parse(n));
void FizzBuzz(int n)
{
    for (int i = 1; i <= n; i++)
    {
        string value = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
        string output = value != "" ? value : i.ToString();
        Console.WriteLine(output);
    }
}