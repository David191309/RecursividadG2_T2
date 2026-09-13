class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Factorial(n - 1);
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void ImprimirNumeros(int n)
    {
        if (n == 0)
            return;

        ImprimirNumeros(n - 1);
        Console.WriteLine(n);
    }

    static void Main()
    {
        Console.WriteLine("Factorial de 5: " + Factorial(5));
        Console.WriteLine("Fibonacci de 6: " + Fibonacci(6));

        Console.WriteLine("\nNumeros del 1 al 5:");
        ImprimirNumeros(5);
    }
}
