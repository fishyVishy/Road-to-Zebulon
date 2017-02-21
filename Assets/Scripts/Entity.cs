﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	private float health;
	public GameObject timer;
	private bool turnTaken;
	private float speed;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public float Health {
		get {
			return health;
		}
		set {
			health = value;
		}
	}

	public float Speed {
		get {
			return speed;
		}
		set {
			speed = value;
		}
	}

	public bool checkTime() {
		if (timer.GetComponent<Timer>().TurnTime < 1.0f) {
			return true;
		} else {
			return false;
		}
	}

	public bool TurnTaken {
		get {
			return turnTaken;
		}
		set {
			turnTaken = value;
		}
	}
}
