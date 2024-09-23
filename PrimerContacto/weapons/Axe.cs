namespace PrimerContacto.weapons;

public class Axe : Weapon
{
    public string name { get; set; }
    public int damage;
    
    /// <summary>
    /// esta es el constructor primario de la clase hacha 
    /// </summary>
    /// <param name="name">nombre del objeto</param>
    /// <param name="damage">dano del objeto</param>
    public Axe(string name, int damage): base(name, damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public override string ToString()
    {
        return name + " : " + damage + "daño";
    }
}