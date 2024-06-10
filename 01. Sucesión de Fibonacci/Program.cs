
// Sucesión de Fibonacci
// 0, 1, 1, 2, 3, 5, 8, 13, 21 ...
Console.WriteLine("Escoge la longitud de Fibonacci N:");
string n = Console.ReadLine();
Fibonacci(int.Parse(n));
void Fibonacci(int n)
{
    int a = 0; int b = 1; int temp;
    List<int> result = new List<int> { a, b };
    for (int i = 0; i < n-1; i++)
    {
        // a + b = temp  -> (a=b) + (b=temp) = temp;
        // En cada vuelta A toma el valor B, y B el valor de temp
        temp = a + b;
        a = b;
        b = temp;
        result.Add(temp);
    }
    // result.ForEach(value => Console.WriteLine(value));
    Console.WriteLine(string.Join(", ", result));
}
