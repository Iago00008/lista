class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número:");
        int num = Convert.ToInt32 (Console.ReadLine()); 

        bool resultado = num < 10 || num > 20;

        if (resultado)
        {
            Console.WriteLine("Fora do intervalo.");
        }
        else
        {
            Console.WriteLine("Dentro do intervalo.");
        }

    }
}