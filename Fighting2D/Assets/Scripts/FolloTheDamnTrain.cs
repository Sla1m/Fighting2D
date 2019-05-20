using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FolloTheDamnTrain : MonoBehaviour {
    public int curHealth;
    public float speed = 5f;
    public Transform player;

	public Text myResult;
	public Text myHealth;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = player.position - transform.position;
        delta.Normalize();
        float move = speed * Time.deltaTime;
        transform.position = transform.position + (delta * move);
		myHealth.text = "HP: " + curHealth.ToString();

        if (curHealth <= 0)
        {
            Destroy(gameObject);
			myResult.text = "You win";
			GlobalBalance.balance += 5;
        }
    }

    public void Damage(int damage)
    {
        curHealth -= damage;
    }

}