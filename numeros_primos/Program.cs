internal class Program
{
    static int NumeroPrimo(double numero)
    {
        int divisores = 0;
        for (int i = 1; i <= int.Parse(numero.ToString()); i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }
        return divisores;
    }
    private static void Main(string[] args)
    {
        double numero;
        int divisoresTotal;

        Console.Write("Informe um numero: ");
        numero = double.Parse(Console.ReadLine());

        divisoresTotal = NumeroPrimo(numero);

        if (divisoresTotal == 2)
        {
            Console.WriteLine($"{numero} é um numero primo!");
        }
        else
        {
            Console.WriteLine($"{numero} não é um numero primo!");
        }
    }
}