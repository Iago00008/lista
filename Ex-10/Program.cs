class Program
{
    public static void Main()
    {
        int idade = 67;
        bool comportamentoSuspeito = true;

        if (idade < 18 || comportamentoSuspeito)
        {
            Console.WriteLine("Monitorar.");
        }
        else
        {
            Console.WriteLine("Não é necessário monitorar.");
        }
    }
}