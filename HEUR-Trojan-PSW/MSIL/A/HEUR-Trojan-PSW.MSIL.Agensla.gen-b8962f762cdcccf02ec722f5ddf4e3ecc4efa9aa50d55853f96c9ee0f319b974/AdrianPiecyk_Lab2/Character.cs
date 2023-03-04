using System;

namespace AdrianPiecyk_Lab2;

public class Character
{
	public int attack = 0;

	public string spellcastfirst = "";

	public string spellcastsecond = "";

	public string spellcastthird = "";

	public string NameOfCharacter { get; set; }

	public int AbilityPower { get; set; }

	public int AttackDamage { get; set; }

	public int HP { get; set; }

	public int Mana { get; set; }

	public int MAXHP { get; set; }

	public int MAXMana { get; set; }

	public Character()
	{
	}

	public Character(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana)
	{
		NameOfCharacter = nameOfCharacter;
		AbilityPower = abilityPower;
		AttackDamage = attackDamage;
		HP = hp;
		Mana = mana;
		MAXHP = hp;
		MAXMana = mana;
	}

	public virtual int Attack()
	{
		return attack;
	}

	public int PercentHP()
	{
		return (int)Math.Floor((double)HP / (double)MAXHP * 100.0);
	}

	public int PercentMana()
	{
		return (int)Math.Floor((double)Mana / (double)MAXMana * 100.0);
	}

	public virtual string Spellfirst()
	{
		return spellcastfirst;
	}

	public virtual string Spellsecond()
	{
		return spellcastsecond;
	}

	public virtual string Spellthird()
	{
		return spellcastthird;
	}
}
