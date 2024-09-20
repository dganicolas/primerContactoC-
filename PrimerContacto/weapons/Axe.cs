namespace PrimerContacto.weapons;

public class Axe : Weapon
{
    string name;
    int damage;
    
    /// <summary>
    /// esta es el constructor primario de la clase hacha 
    /// </summary>
    /// <param name="Name">nombre del objeto</param>
    /// <param name="damage">dano del objeto</param>
    public Axe(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    
}