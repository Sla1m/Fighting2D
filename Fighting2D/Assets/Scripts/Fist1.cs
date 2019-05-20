using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist1 : MonoBehaviour {
    public float lifetime = 0.15f;
    public float speed = 5f;
    public int damage = 1;
    private Transform player;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifetime);
        player = GameObject.Find("attacker-2").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = player.position - transform.position;
        delta.Normalize();
        float move = speed * Time.deltaTime;
        transform.position = transform.position + (delta * move);
	}
}
