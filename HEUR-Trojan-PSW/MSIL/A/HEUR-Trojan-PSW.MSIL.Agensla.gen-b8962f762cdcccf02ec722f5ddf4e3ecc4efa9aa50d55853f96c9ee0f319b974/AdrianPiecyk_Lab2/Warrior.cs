namespace AdrianPiecyk_Lab2;

internal class Warrior : Character
{
	protected string berserker = "BERSERKERRRRRRRRR!!!!!!";

	protected string demacia = "AAAAAaaaaa DEMACIA MY FRIEND!!!!!!!!!";

	protected string hpBooster = "MORE more HP HEAL ME!";

	protected int attackwarr = 0;

	public Warrior()
	{
	}

	public Warrior(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana)
		: base(nameOfCharacter, abilityPower, attackDamage, hp, mana)
	{
		base.NameOfCharacter = nameOfCharacter;
		base.AbilityPower = abilityPower;
		base.AttackDamage = attackDamage;
		base.HP = hp;
		base.Mana = mana;
		base.MAXHP = hp;
	}

	public override int Attack()
	{
		attackwarr = base.AttackDamage;
		return attackwarr;
	}

	public override string Spellfirst()
	{
		return berserker;
	}

	public override string Spellsecond()
	{
		return demacia;
	}

	public override string Spellthird()
	{
		return hpBooster;
	}
}
