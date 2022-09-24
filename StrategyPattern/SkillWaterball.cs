public class SkillWaterball : ISkill
{
    public int attack(Hero attackingHero, Hero attackedHero)
    {
        int injunt = attackingHero.GetWisom() * 2;
        attackedHero.lostHP(injunt);
        return injunt;
    }

    public override string ToString() => "水球";
}