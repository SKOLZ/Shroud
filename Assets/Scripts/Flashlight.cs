using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public float batteryLife = 100.0f;
	public Light flashlight;
	public float batteryConsumption = 1.0f;
	public GameObject battery;
	public AudioClip batteryWarning;
	public AudioClip flashlightSwitch;
	private bool warned = false;

	void Start() {
		flashlight.enabled = false;
	}

	void Update () {
		if (flashlight.enabled) {
			flashlight.intensity = 2 * (batteryLife / 100);
			batteryLife -= (batteryConsumption * Time.deltaTime);
		}
		if (!warned && batteryLife <= 50.0f) {
			warned = true;
			audio.clip = batteryWarning;
			audio.Play();
		}

		if (batteryLife <= 0) {
			batteryLife = 0;
			flashlight.enabled = false;
		}

		if (Input.GetMouseButtonDown (0) && batteryLife > 0) {
			if(!audio.isPlaying) {
				audio.clip = flashlightSwitch;
				audio.Play();
			}
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
