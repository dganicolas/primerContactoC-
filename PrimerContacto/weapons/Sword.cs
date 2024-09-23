namespace PrimerContacto.weapons;

public class Sword : Weapon
{
    string Name;
    int damage;
    /// <summary>
    /// esta es el constructor primario de la clase espada 
    /// </summary>
    /// <param name="name">nombre del objeto</param>
    /// <param name="damage">dano del objeto</param>
    public Sword(string name, int damage):base(name,damage)
    {
        this.Name = name;
        this.damage = damage;
    }
    
}