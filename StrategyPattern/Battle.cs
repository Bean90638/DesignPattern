public partial class Battle
{
    private Hero[] heroes = new Hero[2];

    public Battle(Hero hero1, Hero hero2)
    {
        heroes[0] = hero1;
        heroes[1] = hero2;
    }

    /// <summary>
    /// 開始決鬥! 輪流出招~
    /// </summary>
    public void start()
    {
        int turn = 1;

        while (!isGameOver())
        {
            turn = turn == 0 ? 1 : 0;
            processHeroTurn(turn);
        }

        Console.WriteLine($"勝利者為{heroes[turn].GetName()}");
    }

    /// <summary>
    /// 進行攻擊
    /// </summary>
    /// <param name="heroIndex">判斷攻擊方(0:hero1 1:hero2)</param>
    private void processHeroTurn(int heroIndex)
    {
        Hero attackingHero = heroes[heroIndex];
        Hero attackedHero = heroes[heroIndex == 0 ? 1 : 0];
        attackingHero.attack(attackedHero);

        if (!isGameOver()) Console.WriteLine($"接下來換{attackedHero.GetName()}攻擊");
    }

    /// <summary>
    /// 判斷是否有人血量歸零
    /// </summary>
    /// <returns></returns>
    private bool isGameOver()
    {
        return !heroes[0].IsAlive() || !heroes[1].IsAlive();
    }
}