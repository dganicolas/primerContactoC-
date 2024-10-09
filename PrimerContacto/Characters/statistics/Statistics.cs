namespace PrimerContacto.Characters.statistics;

public class Statistics
{
    public string name;
    public int armorBase;
    public int maxHitPoints;
    public int healthPoints;
    public int baseDamage;

    public Statistics(string name, int armorBase, int maxHitPoints, int healthPoints, int baseDamage)
    {
        this.name = name;
        this.armorBase = armorBase;
        this.maxHitPoints = maxHitPoints;
        this.healthPoints = healthPoints;
        this.baseDamage = baseDamage;
        this.maxHitPoints = maxHitPoints;
        this.healthPoints = healthPoints;
        this.baseDamage = baseDamage;
    }

    public override string ToString()
    {
        return $"name: {name}\n armor base: {armorBase} \n heatlh: {healthPoints}/{maxHitPoints} \n base: {baseDamage}";
    }
}