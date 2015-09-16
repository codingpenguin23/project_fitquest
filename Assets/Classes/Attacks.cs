using UnityEngine;
using System.Collections;

public class Attacks : MonoBehaviour
{

	private string name;
	private int damage;
	private int apCost;

	public Attacks (string attackName, int attackDamage,int attackAPCost)
	{
		name = attackName;
		damage = attackDamage;
		apCost = attackAPCost;
	}

	public string getAttackName()
	{
		return name;
	}
	public int getAttackDamage()
	{
		return damage;
	}
	public int getAPCost()
	{
		return apCost;
	}
}
