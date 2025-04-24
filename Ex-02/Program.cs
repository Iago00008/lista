class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Você tem carteira de motorista? (s/n):");
        string resposta = Console.ReadLine().ToLower();
        bool Carteira = resposta == "s";

        bool podeDirigir = idade >= 18 && Carteira;

        if (podeDirigir)
        {
            Console.WriteLine("Pode dirigir.");
        }
        else
        {
            Console.WriteLine("Não pode dirigir.");
        }


   }
}