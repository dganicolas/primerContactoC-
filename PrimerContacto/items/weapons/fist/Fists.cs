namespace PrimerContacto.protection;

public class Fists : Weapon
{
    public string name;
    public int damage;
    public Fists(string name,int damage):base(name,damage)
    {
        this.name = name;
        this.damage = damage;
    }
}