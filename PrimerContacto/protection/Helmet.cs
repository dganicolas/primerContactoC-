namespace PrimerContacto.protection;

public class Helmet : Protection
{
    string name;
    int armor;
    public Helmet(string Name, int armor)
    {
        this.name = Name;
        this.armor = armor;
    }
}