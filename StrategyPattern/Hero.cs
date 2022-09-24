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

    /// <summary>
    /// 發動攻擊
    /// </summary>
    /// <param name="targetHero">被攻擊英雄</param>
    public void attack(Hero targetHero)
    {
        //使用傳入的介面類別，執行攻擊
        int injunt = skill.attack(this, targetHero);

        Console.WriteLine($"{GetName()}使用{skill}對{targetHero.name}造成了{injunt}點傷害");
        Console.WriteLine($"{targetHero.name}血量剩下{targetHero.HP}");
    }

    /// <summary>
    /// 扣血
    /// </summary>
    /// <param name="hp">血量</param>
    public void lostHP(int hp)
    {
        SetHP(GetHp() - hp);
    }

    /// <summary>
    /// 設定目前血量，小於零則為零
    /// </summary>
    /// <param name="hp">血量</param>
    private void SetHP(int hp)
    {
        this.HP = hp < 0 ? 0 : hp;
    }

    #region 取得類別資訊
    public string GetName() => this.name;

    public bool IsAlive() => this.HP > 0;

    public int GetHp() => this.HP <= 0 ? 0 : this.HP;

    public int GetMp() => this.MP <= 0 ? 0 : this.MP;

    public int GetDefense() => this.defense;

    public int GetStrength() => this.strength;

    public int GetWisom() => this.wisom; 
    #endregion
}
