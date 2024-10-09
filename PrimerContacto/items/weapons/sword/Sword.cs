namespace PrimerContacto.weapons;

public class Sword : Weapon
{
    string name;
    int damage;
    /// <summary>
    /// this is the primary constructor of the sword class 
    /// </summary>
    /// <param name="name">object name</param>
    /// <param name="damage">object damage</param>
    public Sword(string name, int damage):base(name,damage)
    {
        this.name = name;
        this.damage = damage;
    }
    
}