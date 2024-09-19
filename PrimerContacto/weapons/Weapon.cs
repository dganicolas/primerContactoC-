using PrimerContacto;

public abstract class Weapon : Item
{
    public string name;
    int damage = 10;

    public void apply(Character character)
    {
        character.damage = character.baseDamage+damage;
        
    }
}