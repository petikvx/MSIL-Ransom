namespace AdrianPiecyk_Lab2;

internal class Mage : Character
{
	private string firebomb = "Fire bomb RUN!!!!!!!";

	private string darkpulse = "AAAAAaaaaa Dark Pulse You're death!!!!!!!!!";

	private string manarestore = "MY mana back ahahahahaa";

	private int attackmag = 0;

	public Mage()
	{
	}

	public Mage(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana)
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
		attackmag = base.AttackDamage / 2;
		return attackmag;
	}

	public override string Spellfirst()
	{
		return firebomb;
	}

	public override string Spellsecond()
	{
		return darkpulse;
	}

	public override string Spellthird()
	{
		return manarestore;
	}
}
