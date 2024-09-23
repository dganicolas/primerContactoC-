using PrimerContacto;

public abstract class Weapon : Item
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void apply(Character character)
    {
        character.damage = character.baseDamage+damage;
        
    }
}