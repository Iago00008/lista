class Program
{
    public static void Main()
    {
        bool temIngresso = false;
        bool documentoValido = true;

        if (temIngresso && documentoValido)
        {
            Console.WriteLine("Entrada permitida.");
        }
        else
        {
            Console.WriteLine("Entrada negada.");
        }
    }
}