public interface ISkill
{
    /// <summary>
    /// 傷害計算
    /// </summary>
    /// <param name="attackingHero">攻擊方英雄</param>
    /// <param name="attackedHero">被攻擊方英雄</param>
    /// <returns></returns>
    int attack(Hero attackingHero, Hero attackedHero);
}