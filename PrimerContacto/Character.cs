using PrimerContacto;
using PrimerContacto.protection;
using PrimerContacto.weapons;
using PrimerContacto.Mascotas;
///<summary>
/// esta clase es la que representa al jugador
///</summary>
public class Character
{
    string name;
    public int armorBase;
    private int maxHitPoints;
    public int healthPoints;
    public int baseDamage;
    public int damage;
    private List<Item> items;
    public Weapon? armaEquipada;
    public Protection? armaduraEquipada;
    delegate Pets pets();
    private pets petsDelegate;
    public delegate int moreDamage();//puede almacenar codigo, tipo codigo que un casco me cure vida o que una espada me sume mas daño
    public moreDamage moreDamageDelegate;
    public delegate int moreDefense();
    public moreDefense moreDefenseDelegate;
    
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
        items = new List<Item>();
    }

    
    public int attack()
    {
        return damage + moreDamageDelegate();
    }
    
    public int defence()
    {
        return armorBase + moreDefenseDelegate();
    }

    public Protection equipProctection()
    {
        Dictionary<int,Protection> weaponList = crearDiccionarioProtection();
        int numero = int.Parse(Console.ReadLine())-1;
        return cambiarProtection(weaponList[numero]);;
    }

    private Dictionary<int,Protection> crearDiccionarioProtection()
    {
        Dictionary<int, Protection> weaponList = new Dictionary<int, Protection>();
        int indexado = 0;
        int contador = 1;
        foreach (var item in items)
        {
            if (item is Protection protection)
            {
                Console.WriteLine("(" + contador + ") " + "armadura: " + protection.name + " defensa: " + protection.armor);
                weaponList.Add(indexado, protection);
            }
            indexado++;
        }

        return weaponList;
    }
    private Protection cambiarProtection(Protection armaduraEscogida)
    {
        if (armaduraEquipada == null)
        {
            items.Remove(armaduraEscogida);
            armaduraEquipada = armaduraEscogida;
            armaduraEscogida.apply(this);
            return armaduraEscogida;
        }
        else
        {
            items.Add(armaduraEquipada);
            items.Remove(armaduraEscogida);
            armaduraEquipada = armaduraEscogida;
            armaduraEscogida.apply(this);
            return armaduraEscogida;
        }
        
    }
    public Weapon equipWeapon()
    {
     Dictionary<int,Weapon> weaponList = crearDiccionarioArmas();
     int numero = int.Parse(Console.ReadLine())-1;
     return cambiarArmas(weaponList[numero]);;
    }
    
    private Weapon cambiarArmas(Weapon armaEscogida)
    {
        if (armaEquipada == null)
        {
            items.Remove(armaEscogida);
            armaEquipada = armaEscogida;
            armaEquipada.apply(this);
            return armaEscogida;
        }
        else
        {
            items.Add(armaEquipada);
            items.Remove(armaEscogida);
            armaEquipada = armaEscogida;
            armaEquipada.apply(this);
            return armaEscogida;
        }
    }

    private Dictionary<int,Weapon> crearDiccionarioArmas()
    {
        Dictionary<int, Weapon> weaponList = new Dictionary<int, Weapon>();
        int indexado = 0;
        int contador = 1;
        foreach (var item in items)
        {
            if (item is Weapon weapon)
            {
                Console.WriteLine("(" + contador + ") " + "arma: " + weapon.name + " daño: " + weapon.damage);
                weaponList.Add(indexado, weapon);
            }
            indexado++;
        }

        return weaponList;
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