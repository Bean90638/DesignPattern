public class Colliding : ISkill
{
    public int attack(Hero attackingHero, Hero attackedHero)
    {
        int injunt = attackingHero.GetStrength() - attackedHero.GetDefense();
        attackedHero.lostHP(injunt);
        return injunt;
    }

    /// <summary>
    /// 招式名稱
    /// </summary>
    public override string ToString() => "衝撞";
}