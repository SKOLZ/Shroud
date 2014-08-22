using UnityEngine;
using System.Collections;

public class Daylight : MonoBehaviour {

	public Light daylight;
	public ClockManager cm;
	public float baseIntensity = 0.4f;
	public float dayIntensity = 0.6f;
	public float daySpeed = 0.01f;
	public float nightTime = 5.0f;
	public float darknessIntencity = 0.008f;

	void FixedUpdate () {
		if (cm.getHour() > 17 && cm.getHour() < 21 ) {
			if(daylight.intensity > 0.008f) {
				daylight.intensity -= (daySpeed * Time.fixedDeltaTime);
			}
		} else if (cm.getHour() > 5 && cm.getHour() < 17) {
			daylight.intensity += (daySpeed * Time.fixedDeltaTime);
			nightTime -= (daySpeed * Time.fixedDeltaTime);
		}
	}
}
