namespace PrimerContacto.protection;

public class Helmet : Protection
{
    string name;
    int armor;
    
    /// <summary>
    /// esta es el constructor primario de la clase casco 
    /// </summary>
    /// <param name="Name">nombre del objeto</param>
    /// <param name="armor">defensa del objeto</param>
    public Helmet(string Name, int armor)
    {
        this.name = Name;
        this.armor = armor;
    }
}