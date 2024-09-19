using PrimerContacto.weapons;
using PrimerContacto.protection;

class Program
{
    
    static void Main(string[] args)
    {
        Character nicolas = new Character("nico", 5, 5, 5);
        Axe hacha = new Axe("hacha", 5);
        Helmet helmet = new Helmet("helmet",5);
        Console.WriteLine(nicolas.attack());
        nicolas.addItem(hacha);
        Console.WriteLine(nicolas.attack());
        nicolas.removeItem(hacha);
        Console.WriteLine(nicolas.attack());
        Console.WriteLine(nicolas.defence());
        nicolas.addItem(helmet);
        Console.WriteLine(nicolas.defence());
        nicolas.removeItem(helmet);
        Console.WriteLine(nicolas.defence());
    }
}