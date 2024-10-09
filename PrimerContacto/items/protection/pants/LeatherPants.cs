﻿namespace PrimerContacto.protection;

public class LeatherPants:Pants
{
    public string name;
    public int armor;
    
    /// <summary>
    /// esta es el constructor primario de la clase casco 
    /// </summary>
    /// <param name="name">nombre del objeto</param>
    /// <param name="armor">defensa del objeto</param>
    public LeatherPants(string name, int armor):base(name,armor)
    {
        this.name = name;
        this.armor = armor;
    }
}