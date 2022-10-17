using System.Timers;

public class Statusffect : BaseEffect
{
    public CharacterStat affectStat;
    public int amount;
    public bool dps = false;
    public float lifeTime;
    Timer timer;

    public override void Apply(Character character)
    {
        base.Apply(character);
        if (dps)
        {
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }
        else
        {
            switch (affectStat)
            {
                case CharacterStat.Armor:
                    character.armor += amount;
                    break;
                case CharacterStat.Atk:
                    character.atk += amount;
                    break;
                default:
                    break;
            }
            timer = new Timer(lifeTime*1000);
            timer.Elapsed += Timer_Elapsed;
        }
        timer.Start();
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        if (dps)
        {
            switch (affectStat)
            {
                case CharacterStat.Hp:
                    character.hp -= amount;
                    break;
                default:
                    break;
            }
        }
        lifeTime -= (float)(timer.Interval / 1000);
        if (lifeTime <= 0)
        {
            timer.Stop();
            TearDown();
        }
    }

    public override void TearDown()
    {
        base.TearDown();
        if (!dps)
        {
            switch (affectStat)
            {
                case CharacterStat.Armor:
                    character.armor -= amount;
                    break;
                case CharacterStat.Atk:
                    character.atk -= amount;
                    break;
                default:
                    break;
            }
        }
    }

    public override BaseEffect Clone()
    {
        var newEffect = new Statusffect();
        newEffect.lifeTime = this.lifeTime;
        newEffect.affectStat = this.affectStat;
        newEffect.amount = this.amount;
        newEffect.dps = this.dps;
        return newEffect;
    }
}