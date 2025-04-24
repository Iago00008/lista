class Program
{
    public static void Main()
    {
      

        string usuario = "admin"; 

        if (usuario == "admin" || usuario == "supervisor")
        {
            Console.WriteLine("Acesso liberado.");
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }



    }
}