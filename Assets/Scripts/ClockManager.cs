using UnityEngine;
using System.Collections;

public class ClockManager : MonoBehaviour {

	public GUIText clock;
	private int hour = 18;
	private int minutes = 7;
	private float currentTime;

	void onStart() {
		currentTime = Time.time;
		alterClock ();
	}

	void FixedUpdate () {
		float newTime = Time.time;
		if (newTime - currentTime > 0.2f) {
			alterClock ();
			currentTime = newTime;
		}
	}

	void alterClock() {
		if((minutes+1)%60 == 0 ) {
			minutes = 0;
			hour +=1;
			if(hour == 24) {
				hour = 0;
			}
		} else {
			minutes += 1;
		}
		generateClockText ();
	}

	public int getHour() {
				return hour;
		}
	public int getMinutes() {
				return minutes;
		}
	void generateClockText(){
		string hh;
		string mm;

		if(hour < 10 ) {
			hh = "0" + hour;
		} else {
			hh = hour.ToString();
		}
		if(minutes < 10) {
			mm = "0" + minutes;
		} else {
			mm = minutes.ToString();
		}
		clock.text = hh + ":" + mm;
	}
}