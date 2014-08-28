using UnityEngine;
using System.Collections;

public class FinisherManager : MonoBehaviour {

	public ClockManager cm;

	void Start () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		if(cm.getHour() > 8 && cm.getHour() < 17) {
			Application.LoadLevel(3);
		} else {
			//play audio 
		}
	}
}
