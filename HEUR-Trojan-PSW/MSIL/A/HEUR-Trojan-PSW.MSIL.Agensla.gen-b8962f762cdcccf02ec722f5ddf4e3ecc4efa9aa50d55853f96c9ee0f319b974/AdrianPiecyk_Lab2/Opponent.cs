using System;

namespace AdrianPiecyk_Lab2;

internal class Opponent : Character
{
	public Opponent()
	{
	}

	public Opponent(string nameOfCharacter, int abilityPower, int mana, int attackDamage, int hp)
		: base(nameOfCharacter, abilityPower, attackDamage, hp, mana)
	{
		base.NameOfCharacter = nameOfCharacter;
		base.AttackDamage = attackDamage;
		base.AbilityPower = 0;
		base.Mana = 0;
		base.HP = hp;
		base.MAXHP = hp;
	}

	public override int Attack()
	{
		Random random = new Random();
		attack = random.Next(10, 70);
		return attack;
	}
}
