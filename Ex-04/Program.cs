class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite sua renda:");
        double renda = Convert.ToDouble(Console.ReadLine());

        bool resposta = idade > 65 || renda < 2000.0;

        if (resposta)
        {
            Console.WriteLine("Está isento de imposto.");
        }
        else
        {
            Console.WriteLine("Não está isento de imposto.");
        }

    }
}