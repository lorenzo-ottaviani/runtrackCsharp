namespace job4;

class Program
{
    int Carree(int n)
    {
        return n * n;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Choisir un nombre : ");

        try
        {
            string? entree = Console.ReadLine();
            int nombre = int.Parse(entree);
        }
        catch
        {
            Console.WriteLine("Nombre invalide");
        }
        
    }
}