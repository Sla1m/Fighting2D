using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyWeapon : MonoBehaviour {

	public Text balance;
	public Text weaponDmg;

	public void buyDagger()
	{
		if (GlobalBalance.balance >= 90) {
			GlobalBalance.balance -= 90;
			GlobalBalance.weaponDamage = 10;
		}
	}

	public void buySword()
	{
		if (GlobalBalance.balance >= 200) {
			GlobalBalance.balance -= 200;
			GlobalBalance.weaponDamage = 25;
		}
	}

	public void buyAxe()
	{
		if (GlobalBalance.balance >= 500) {
			GlobalBalance.balance -= 500;
			GlobalBalance.weaponDamage = 50;
		}
	}

	public void buyHammer()
	{
		if (GlobalBalance.balance >= 1000) {
			GlobalBalance.balance -= 1000;
			GlobalBalance.weaponDamage = 100;
		}
	}
	
	// Update is called once per frame
	void Update () {
		balance.text = "Balance: " + GlobalBalance.balance.ToString ();
	}
}
