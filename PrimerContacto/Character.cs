using PrimerContacto;
using PrimerContacto.protection;

///<summary>
/// esta clase es la que representa al jugador
///</summary>
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
    
    ///<summary>
    /// este es el constructor principal, donde se inicizializaran la clase
    /// <param name="name"> es el nombre</param>
    /// <param name="armorBase">es la armadura base</param>
    /// <param name="maxHitpoints">es la vida maxima </param>
    /// <param name="baseDamage">es el daño base</param>
    ///</summary>
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
        //compruebo si el jugador en el inventario tiene algun objeto arma
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
        //compruebo si el jugador en el inventario tiene algun objeto defensa
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
    
   
}