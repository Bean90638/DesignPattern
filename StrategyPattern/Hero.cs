public class Hero
{
    private string name;
    private int HP = 500;
    private int MP = 200;
    private int strength = 150;
    private int wisom = 80;
    private int defense = 50;
    private ISkill skill;

    //建構子
    public Hero(string name, ISkill skill)
    {
        this.name = name;
        this.skill = skill;
    }

    public void attack(Hero targetHero)
    {
        int injunt = skill.attack(this, targetHero);

        Console.WriteLine($"{GetName()}使用{skill}對{targetHero.name}造成了{injunt}點傷害");
        Console.WriteLine($"{targetHero.name}血量剩下{targetHero.HP}");
    }

    public void lostHP(int hp)
    {
        SetHP(GetHp() - hp);
    }

    private void SetHP(int hp)
    {
        this.HP = hp < 0 ? 0 : hp;
    }

    public string GetName() => this.name;

    public bool IsAlive() => this.HP > 0;

    public int GetHp() => this.HP <= 0 ? 0 : this.HP;

    public int GetMp() => this.MP <= 0 ? 0 : this.MP;

    public int GetDefense() => this.defense;

    public int GetStrength() => this.strength;

    public int GetWisom() => this.wisom;
}
