using UnityEngine;
using System.Collections;
using System;
public class EnemyMobility : MonoBehaviour {

	public float speed;
	public float detectRadius = 5.0f;
	public GameObject player;
	private float randomTime = 0.0f;
	public float maxRandTime = 3.0f;

	void FixedUpdate() {
		if (player != null){    
			Vector3 dif = (transform.position - player.transform.position );
			if ((Math.Abs (dif.x) < detectRadius && Math.Abs (dif.y) < detectRadius)) {
				HuntPlayer(dif);
			} else {
				RandomMove();
			}
		}
	}

	void HuntPlayer(Vector3 dif) {
		randomTime = -1.0f;
		float z = Mathf.Atan2 (-dif.y, -dif.x) * Mathf.Rad2Deg - 90;
		transform.eulerAngles = new Vector3 (0, 0, z);
		rigidbody2D.AddForce (gameObject.transform.up * speed);
	}

	void RandomMove() {
		randomTime -= Time.fixedDeltaTime;
		if (randomTime <= 0.0f) {
			transform.eulerAngles = new Vector3 (0, 0, UnityEngine.Random.Range (0.0f, 360.0f));
			randomTime = maxRandTime;
		}
		rigidbody2D.AddForce (gameObject.transform.up * speed * 0.7f);
	}
}
