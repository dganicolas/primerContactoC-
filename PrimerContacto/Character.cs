using PrimerContacto;
using PrimerContacto.protection;

public class Character
{
    string name;
    public int armor;
    public int armorBase;
    int maxHitPoints;
    int healthPoints;
    public int baseDamage;
    public int damage;
    private List<Item> items;

    public Character(string name, int armorBase, int maxHitpoints, int baseDamage)
    {
        this.name = name;
        this.armorBase = armorBase;
        this.maxHitPoints = maxHitpoints;
        this.healthPoints = maxHitpoints;
        this.baseDamage = baseDamage;
        damage = baseDamage;
        armor = armorBase;
        items = new List<Item>();
    }
    public int attack()
    {
        damage = baseDamage;
        foreach (var item in items)
        {
            if (item is Weapon)
            {
                item.apply(this);
                
            }
        }
        return damage;
    }

    public int defence()
    {
        armor = armorBase;
        foreach (var item in items)
        {
            if (item is Protection)
            {
                item.apply(this);
                break;
            }
        }

        return armor;
    }
    
    public void addItem(Item item)
    {
        items.Add(item);
    }

    public void removeItem(Item item)
    {
        items.Remove(item);
    }
    
    public void heal(int cured)
    {
        if (cured + healthPoints >= maxHitPoints)
        {
            healthPoints = maxHitPoints;
        }
        else
        {
            healthPoints += cured;
        }
    }
}