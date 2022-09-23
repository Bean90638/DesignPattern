public enum Skill
{
    Colliding,
    Waterball
}

public class Hero
{
    private string name;
    private int HP = 500;
    private int MP = 200;
    private int strength = 150;
    private int wisom = 80;
    private int defense = 50;
    private Skill skill;

    //建構子
    public Hero(string name, Skill skill)
    {
        this.name = name;
        this.skill = skill;
    }

    public void attack(Hero targetHero)
    {
        switch (skill)
        {
            case Skill.Colliding:
                Console.WriteLine($"對{targetHero.name}使用了 衝撞攻擊!");
                targetHero.lostHP(getStrength() - targetHero.GetDefense());
                break;
            case Skill.Waterball:
                Console.WriteLine($"對{targetHero.name}使用了 水球攻擊!");
                break;
            default:
                break;
        }

        Console.WriteLine($"{targetHero.name}血量剩下{targetHero.HP}");
    }

    private void lostHP(int hp)
    {
        SetHP(GetHP() - hp);
    }

    private void SetHP(int hp)
    {
        this.HP = hp;
        if (!isAlive())
            Console.WriteLine($"{GetName()}已陣亡");
    }

    public string GetName() => this.name;

    public bool isAlive() => this.HP > 0;

    public int GetHP() => this.HP <= 0 ? 0 : this.HP;
    
    public int GetMP() => this.MP <= 0 ? 0 : this.MP;
    
    public int GetDefense() => this.defense;
    
    public int getStrength() => this.strength;
}

