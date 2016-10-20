﻿using UnityEngine;
using System.Collections;

public class Battler : MonoBehaviour {

	public string nickname;
	public Team team;

	public bool defeated;

	public float attack;
	public float maxHealth;
	public float health;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TakeDamage (float amount) {
		Debug.Log (nickname + " takes " + amount + " damage");
		health = Mathf.Max(0, health - amount);
		if (health == 0) {
			Debug.Log (nickname + " is defeated");
			defeated = true;
		}
	}

	public void Attack (Battler target) {
		Debug.Log (nickname + " attacks " + target.nickname);
		target.TakeDamage (attack);
	}
}