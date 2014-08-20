using UnityEngine;
using System.Collections;

public class Daylight : MonoBehaviour {

	public Light daylight;
	public string state = "dusk";
	public float baseIntensity = 0.4f;
	public float dayIntensity = 0.6f;
	public float daySpeed = 0.01f;
	public float nightTime = 5.0f;

	void FixedUpdate () {
		if (state.Equals ("dusk")) {
				daylight.intensity -= (daySpeed * Time.fixedDeltaTime);
				if (daylight.intensity <= 0.0f)
						state = "night";
		} else if (state.Equals("night")) {
			nightTime -= (daySpeed * Time.fixedDeltaTime);
			if (nightTime <= 0.0f)
				state = "dawn";
		} else if(state.Equals("dawn")) {
			daylight.intensity += (daySpeed * Time.fixedDeltaTime);
			if(daylight.intensity > dayIntensity)
				state = "day";
		}
	}
}
