using UnityEngine;
using System.Collections;
using System;

public class ZombieSounds : RandomSounds {

	public GameObject player;
	public float soundRadius = 2.0f;
	// Update is called once per frame
	void Update () {
		if(closeToPlayer())
			playSound();
	}

	bool closeToPlayer() {
		Vector3 dif = (transform.position - player.transform.position );
		return (Math.Abs(dif.x) < soundRadius && Math.Abs(dif.y) < soundRadius);
	}
}
