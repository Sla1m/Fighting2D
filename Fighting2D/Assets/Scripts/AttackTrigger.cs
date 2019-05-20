using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackTrigger : MonoBehaviour {

	private float dmg = GlobalBalance.damage;
	public Text damage;

	void Start()
	{
		damage.text = "Damage: " + dmg.ToString ();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true)// && col.CompareTag("Enemy"))
        {
            col.SendMessageUpwards("Damage", dmg);
        }
    }
}
