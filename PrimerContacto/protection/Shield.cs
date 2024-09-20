namespace PrimerContacto.protection;

public class Shield : Protection
{
    public string name;
    public int armor;

    /// <summary>
    /// esta es el constructor primario de la clase escudo 
    /// </summary>
    /// <param name="Name">nombre del objeto</param>
    /// <param name="armor">defensa del objeto</param>
    public Shield(string Name, int armor)
    {
        this.name = Name;
        this.armor = armor;
    }
}