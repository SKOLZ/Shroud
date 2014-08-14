using UnityEngine;
using System.Collections;

public class EnemyMobility : MonoBehaviour {

	public float speed;
	public GameObject player;

	void FixedUpdate() {
		float z = Mathf.Atan2 ((player.gameObject.transform.position.y - transform.position.y), (player.gameObject.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);
		rigidbody2D.AddForce (gameObject.transform.up * speed);
	}

	void OnCollisionEnter2D(Collision2D col) 
	{
		if (col.gameObject == player) {
			Debug.Log("asd");	
		}
	}
}
