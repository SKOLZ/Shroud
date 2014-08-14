using UnityEngine;
using System.Collections;
using System;

public class PlayerMobility : MonoBehaviour {

	public float speed;

	void FixedUpdate() {
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		rigidbody2D.angularVelocity = 0;

		/*float input = Input.GetAxis ("Vertical");
		rigidbody2D.AddForce (gameObject.transform.up * speed * input);*/

		if (Input.GetKey (KeyCode.W)) {
			var dif = (mousePosition - transform.position);
			if (Math.Abs(dif.x) > 3 || Math.Abs(dif.y) > 3){
				rigidbody2D.AddForce (gameObject.transform.up * speed);
			}
		}	
		if(Input.GetKey(KeyCode.A)) {
			rigidbody2D.AddForce(-gameObject.transform.right * speed);
		}
		
		if(Input.GetKey(KeyCode.S)) {
			rigidbody2D.AddForce(-gameObject.transform.up * 0.7f * speed);
		}
		
		if(Input.GetKey(KeyCode.D)) {
			rigidbody2D.AddForce(gameObject.transform.right * speed);
		}
	}
}