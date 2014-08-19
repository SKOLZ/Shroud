using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public float batteryLife = 100.0f;
	public Light flashlight;
	public float batteryConsumption = 1.0f;
	public GameObject battery;

	// Update is called once per frame
	void Update () {
		if (flashlight.enabled) {
			flashlight.intensity = 2 * (batteryLife / 100);
			batteryLife -= (batteryConsumption * Time.deltaTime);
		}
		if (batteryLife <= 0) {
			batteryLife = 0;
			flashlight.enabled = false;
		}

		if (Input.GetMouseButtonDown (0) && batteryLife > 0) {
			flashlight.enabled = !flashlight.enabled;
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name.Contains(battery.name)) {
			batteryLife = 100.0f;
			Destroy(col.gameObject);
		}
	}
}
