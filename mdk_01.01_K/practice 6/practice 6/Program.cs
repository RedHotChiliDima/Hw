class Program
{
    static void Main(string[] args)
    {
        Warlock hero = new Warlock(100,100);
        ((ISummoner)hero).Summon(2);
        
    }
}
public interface IMeleeFighter
{
    int damage { get; set; }
    public void Attack(Creature target)
    {
        target.TakeDamage(damage);
    }
}
public interface ISpellcaster
{
    int maxMana { get;}
    int mana { get; set; }

    public void CastSpell(string spell,int manaCost)
    {
        if (manaCost <= mana)
        {
            Console.WriteLine(spell + "!!!");
            mana -= manaCost;
        }
        else
        {
            Console.WriteLine("Не хватает маны");
        }
    }
}
interface IHealer
{
    int maxMana { get;}
    int mana { get; set; }

    public void Heal(Creature target, int healPoints)
    {
        if (healPoints <= mana)
        {
            target.TakeDamage(-healPoints);
            mana -= healPoints;
        }
        else
        {
            Console.WriteLine("Не хватает маны");
        }
    }
}
interface IStealth
{
    public void StealthWalk(string kuda)
    {
        Console.WriteLine("Тихонечко пошел " + kuda);
    }
}
interface ISummoner
{
    int maxMana { get; }
    int mana { get; set; }
    Creature summonedCreature { get; }

    public void Summon(int count)
    {
        if (count > 0)
        {
            if (count * 15 <= mana)
            {
                Console.WriteLine("Призваны " + count + ' ' + summonedCreature.ToString());
            }
            else { Console.WriteLine("Не хватает маны"); }
        }
        else { Console.WriteLine("нет"); }
    }

}
public abstract class Creature
{
    int health {get; set;} = 100;
    int maxHealth { get; } = 100;

    public Creature(int maxHealth)
    {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
    }

    Creature()
    {
        this.maxHealth = 100;
        ;
        this.health = maxHealth;
    }

    internal void TakeDamage(int damage)
    { 
        health -= damage;

        if (damage > 0)
        {
            Console.WriteLine("Получил урон: " + damage);
        }
        else
        {
            Console.WriteLine("Получил лечение: " + -damage);
        }

        if (health < 1)
        {
            this.Dead();
        }
    }

    internal void Walk(string kuda)
    { 
        Console.WriteLine("Пошел " + kuda);
    }
    protected void Dead()
    {
        Console.WriteLine(this.ToString() + " Погиб");
    }
}
public class Warlock : Creature , ISpellcaster, ISummoner
{
    public int maxMana { get; set; }
    public int mana { get; set; }
    public Creature summonedCreature { get; } = new Skeleton(20);

    public Warlock(int maxHealth, int maximumMana) : base(maxHealth)
    {
        maxMana = maximumMana;
        mana = maxMana;
    }
}
public class Ranger : Creature , IMeleeFighter , IStealth
{
    public int damage { get; set; }
    public Ranger(int maxHealth, int Damage) : base(maxHealth) { damage = Damage; }
}
public class Paladin : Creature, IMeleeFighter , IHealer
{
    public int damage { get; set; }
    public int maxMana {  get; set; }
    public int mana { get; set; }
    public Paladin(int maxHealth, int Damage, int MaxMana) : base(maxHealth) 
    {
        damage = Damage;
        maxMana = MaxMana;
        mana = maxMana;
    }
}
public class Bard : Creature, IHealer, ISpellcaster
{
    public int maxMana { get; set; }
    public int mana { get; set; }

    public Bard(int maxHealth, int MaxMana) : base(maxHealth)
    {
        maxMana = MaxMana;
        mana = maxMana;
    }
}
public class Druid : Creature , IMeleeFighter, ISpellcaster
{
    public int damage { get; set; }
    public int maxMana { get; set; }
    public int mana { get; set; }

    public  Druid(int maxHealth, int Damage, int MaxMana) : base(maxHealth)
    {
        damage = Damage;
        maxMana = MaxMana;
        mana = maxMana;
    }
}
public class Skeleton : Creature , IMeleeFighter
{
    public int damage { get; set; } = 10;
    public Skeleton(int maxHealth) : base(maxHealth)
    { }
}