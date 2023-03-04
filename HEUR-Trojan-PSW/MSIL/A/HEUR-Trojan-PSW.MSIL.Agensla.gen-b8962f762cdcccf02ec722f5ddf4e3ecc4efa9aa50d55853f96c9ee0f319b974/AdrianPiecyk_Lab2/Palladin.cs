namespace AdrianPiecyk_Lab2;

internal class Palladin : Character
{
	private string spearthrow = "Taste my spear!!!!!!";

	private string masor = "Don't run away";

	private string furious = "I'm fast and furious!";

	private int attackwarr = 0;

	public Palladin()
	{
	}

	public Palladin(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana)
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
		return spearthrow;
	}

	public override string Spellsecond()
	{
		return masor;
	}

	public override string Spellthird()
	{
		return furious;
	}
}
