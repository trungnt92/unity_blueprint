

public class DamageEffect : BaseEffect
{
    public int damage;
    public bool ignoreArmor;

    public override void Apply(Character character)
    {
        // apply dmg one time no need to add to list
        character.hp -= (damage - (ignoreArmor ? 0 : character.armor));
    }

    public override BaseEffect Clone()
    {
        var newEffect = new DamageEffect();
        newEffect.damage = this.damage;
        newEffect.ignoreArmor = this.ignoreArmor;
        return newEffect;
    }
}
