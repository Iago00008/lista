class Program
{
    public static void Main()
    {
        int hora = 14;

        if (hora >= 6 && hora <= 22)
        {
            Console.WriteLine("Acesso permitido.");
        }
        else
        {
            Console.WriteLine("Fora do horário.");
        }
    }
}