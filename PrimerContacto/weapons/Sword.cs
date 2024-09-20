namespace PrimerContacto.weapons;

public class Sword : Weapon
{
    string Name;
    int damage;
    /// <summary>
    /// esta es el constructor primario de la clase espada 
    /// </summary>
    /// <param name="Name">nombre del objeto</param>
    /// <param name="damage">dano del objeto</param>
    public Sword(string Name, int damage)
    {
        this.Name = name;
        this.damage = damage;
    }
    
}