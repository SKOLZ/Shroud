using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float dampTime = 0.01f;
	private Vector3 velocity = new Vector3(0.6f, 0.6f, 0.0f);
	public Transform target;
	public GameObject gameOverPopup;
	
	// Update is called once per frame
	void Update () {
		if(!gameOverPopup.activeSelf) {
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
