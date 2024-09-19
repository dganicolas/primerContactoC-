namespace PrimerContacto.protection;

public abstract class Protection: Item
{
    string name;
    int armor = 10;

    public void apply(Character character)
    {
        character.armor = character.armorBase+armor;
    }
}