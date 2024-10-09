using PrimerContacto.protection;

namespace PrimerContacto.Characters.statistics;

public class EquippedArmors
{
    public Weapon leftHand;
    public Helmet head;
    public Vest chest;
    public Pants legs;
    public Boots foot;

    public EquippedArmors()
    {
        leftHand = new Fists("fist",1);
        head = new LeatherHelmet("leather helmet",1);
        chest = new LeatherVest("leather armor",1);
        legs = new LeatherPants("leather pants",1);
        foot = new LeatherBoots("leather boots",1);
    }
}