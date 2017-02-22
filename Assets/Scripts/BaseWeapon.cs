﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : Holdable {
	private float damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float Damage {
		get {
			return damage;
		}
		set {
			damage = value;
		}
	}

	public override void Action() {
	}
}
