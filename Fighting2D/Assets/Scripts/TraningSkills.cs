using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraningSkills : MonoBehaviour {

	public Text balance;
	public Text dmg;
	public Text spd;
	public Text jmp;

	public void TraningDamage()
	{
		GlobalBalance.balance -= 15;
		GlobalBalance.damage += 0.1F;
	}

	public void TraningSpeed()
	{
		GlobalBalance.balance -= 15;
		GlobalBalance.speed += 0.1F;
	}

	public void TraningJump()
	{
		GlobalBalance.balance -= 15;
		GlobalBalance.jumpForce += 0.1F;
	}

	private void Update()
	{
		balance.text = "Balance: " + GlobalBalance.balance.ToString ();
		dmg.text = "Damage: " + GlobalBalance.damage.ToString();
		spd.text = "Speed: " + GlobalBalance.speed.ToString();
		jmp.text = "Jump force: " + GlobalBalance.jumpForce.ToString();
	}
	
}
