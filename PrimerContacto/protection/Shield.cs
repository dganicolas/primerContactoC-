namespace PrimerContacto.protection;

public class Shield : Protection
{
    public string name;
    public int armor;

    public Shield(string Name, int armor)
    {
        this.name = Name;
        this.armor = armor;
    }
}