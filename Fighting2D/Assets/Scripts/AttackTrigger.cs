using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackTrigger : MonoBehaviour {

	private float dmg = GlobalBalance.damage + GlobalBalance.weaponDamage;
	private float weaponDmg = GlobalBalance.weaponDamage;
	public Text damage;
	public Text weaponDamage;

	void Start()
	{
		damage.text = "Damage: " + dmg.ToString ();
		weaponDamage.text = "(Weapon damage: " + weaponDmg.ToString () + ")";
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true)// && col.CompareTag("Enemy"))
        {
            col.SendMessageUpwards("Damage", dmg);
        }
    }
}
