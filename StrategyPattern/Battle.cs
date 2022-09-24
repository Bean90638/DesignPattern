public partial class Battle
{
    private Hero[] heroes = new Hero[2];

    public Battle(Hero hero1, Hero hero2)
    {
        heroes[0] = hero1;
        heroes[1] = hero2;
    }

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

    private void processHeroTurn(int heroIndex)
    {
        Hero attackingHero = heroes[heroIndex];
        Hero attackedHero = heroes[heroIndex == 0 ? 1 : 0];
        attackingHero.attack(attackedHero);

        if (!isGameOver()) Console.WriteLine($"接下來換{attackedHero.GetName()}攻擊");
    }

    private bool isGameOver()
    {
        return !heroes[0].IsAlive() || !heroes[1].IsAlive();
    }
}