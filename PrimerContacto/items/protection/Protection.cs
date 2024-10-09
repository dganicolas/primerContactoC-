namespace PrimerContacto.protection;

public abstract class Protection: Item
{
    public string name;
    public int armor = 10;
    
    public Protection(string name, int armor)
    {
        this.name = name;
        this.armor = armor;
    }

    public void apply(Character character)
    {
        character.moreDefenseDelegate += () =>
        {
            return 5;
        };
    }
}