namespace AdrianPiecyk_Lab2;

internal class Assassin : Character
{
	public string shuriken = "SHURIKEN!!!!!!";

	public string dragonswift = "AAAAAaaaaa Dragon Switft!!!!!!!!!";

	public string shadowattack = "Die! Faster DIE!";

	public int attackwarr = 0;

	public Assassin()
	{
	}

	public Assassin(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana)
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
		return shuriken;
	}

	public override string Spellsecond()
	{
		return dragonswift;
	}

	public override string Spellthird()
	{
		return shadowattack;
	}
}
