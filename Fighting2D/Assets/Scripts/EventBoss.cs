using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EventBoss : MonoBehaviour {
	public int GGHealth;
	public int curHealth;
	public float speed = 5f;
	public Transform player;

	public Text myResult;
	public Text enemyHealth;
	public Text myHealth;

	public GameObject attackPlayer;
	public GameObject myPlayer;

	// Use this for initialization
	void Start()
	{

	}

	void OnCollisionEnter2D(Collision2D theCollision)
	{
		if (theCollision.gameObject.name.Contains ("attacker-1")) 
		{
			attackPlayer.GetComponent<Animator> ().SetTrigger ("Enemy_attack");
			GGHealth -= 25;
		}
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 delta = player.position - transform.position;
		delta.Normalize();
		float move = speed * Time.deltaTime;
		transform.position = transform.position + (delta * move);
		myHealth.text = "HP: " + curHealth.ToString();
		enemyHealth.text = "HP: " + GGHealth.ToString();

		if (GGHealth <= 0)
		{
			Destroy(myPlayer);
			myResult.text = "You lose";
		}

		if (curHealth <= 0)
		{
			Destroy(attackPlayer);
			myResult.text = "You win";
			GlobalBalance.balance += 25;
		}
	}

	public void Damage(int damage)
	{
		curHealth -= damage;
	}

}