using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float dampTime = 0.01f;
	private Vector3 velocity = new Vector3(0.6f, 0.6f, 0.0f);
	public Transform target;
	public GameObject gameOverPopup;
	
	private float minX;
	private float maxX;
	private float minY;
	private float maxY;
	private float mapX = 100.0f;
	private float mapY = 100.0f;
	
	void Start() {
		var vertExtent = Camera.main.camera.orthographicSize;   
		var horzExtent = vertExtent * Screen.width / Screen.height;
		minX = horzExtent - mapX / 2.0f;
		maxX = mapX / 2.0f - horzExtent;
		minY = vertExtent - mapY / 2.0f;
		maxY = mapY / 2.0f - vertExtent;
		Debug.Log(minX);
		Debug.Log(maxX);
		Debug.Log(minY);
		Debug.Log(maxY);
		Debug.Log(camera.WorldToViewportPoint(target.position));
	}

	void Update () {
		if(!gameOverPopup.activeSelf) {
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
