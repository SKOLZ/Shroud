using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float dampTime = 0.01f;
	private Vector3 velocity = new Vector3(0.6f, 0.6f, 0.0f);
	public Transform target;
	public GameObject gameOverPopup;
	
	private float vertExtent;
	private float horzExtent;

	public float mapEastLimit;
	public float mapWestLimit;
	public float mapNorthLimit;
	public float mapSouthLimit;
	
	void Start() {
		var vertExtent = Camera.main.camera.orthographicSize;   
		var horzExtent = vertExtent * Screen.width / Screen.height;
	}

	void Update () {
		if(!gameOverPopup.activeSelf) {
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			bool correctY = correctMovementY(destination);
			bool correctX = correctMovementX(destination);
			if(correctY) {
				if(correctX)	
					transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);	
				else {
					transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, destination.y, destination.z), ref velocity, dampTime);
				}
			} else if (correctX)
				transform.position = Vector3.SmoothDamp(transform.position, new Vector3(destination.x, transform.position.y, destination.z), ref velocity, dampTime);
		}
	}

	private bool correctMovementY(Vector3 point) {
		return (point.y + vertExtent < mapNorthLimit) && (point.y - vertExtent > mapSouthLimit);
	}
	
	private bool correctMovementX(Vector3 point) {
		return (point.x + horzExtent < mapEastLimit) && (point.x - horzExtent > mapWestLimit);
	}
}
