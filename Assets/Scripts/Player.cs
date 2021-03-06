﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {
	private Vector3 movement;
	public GameObject rightObj;
	private Holdable rightHand;
	private float maxHealth = 100.0f;
	// Use this for initialization
	void Start () {
		Health = maxHealth;
		Speed = 5.0f;
		TurnTaken = false;
		rightHand = rightObj.GetComponent<Holdable> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			Destroy (gameObject);
		}
		// This if will reset all values to the beginning of the turn.
		if (!checkTime () && !TurnTaken) {
			movement = new Vector3 (0, 0, 0);
		}
		//This will exectute the turn
		if (checkTime ()) {
			Vector3 finMove = Vector3.forward + movement;
			transform.Translate (finMove * Time.deltaTime * Speed);
			TurnTaken = false;
			//This will set the players turn to go left
		} else if (Input.GetKeyDown (KeyCode.F) && !TurnTaken) {
			movement = Vector3.left / 2;
			TurnTaken = true;
			//This will set the players turn to go right
		} else if (Input.GetKeyDown (KeyCode.J) && !TurnTaken) {
			movement = Vector3.right / 2;
			TurnTaken = true;
		} else if (Input.GetKeyDown (KeyCode.L) && !TurnTaken) {
			rightHand.Action ();
			TurnTaken = true;
		}
	}
}
