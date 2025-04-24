class Program
{
    public static void Main()
    {
        bool cadastrado = true;
        bool cupomValido = true;
        bool jaUsouCupom = false;

        if ((cadastrado && cupomValido) && !jaUsouCupom)
        {
            Console.WriteLine("Promoção válida.");
        }
        else
        {
            Console.WriteLine("Promoção inválida.");
        }
    }
}