using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputBalance : MonoBehaviour {

	public Text balance;
	
	// Update is called once per frame
	void Start () 
	{
		balance.text = "Balance: " + GlobalBalance.balance.ToString ();
	}
}
