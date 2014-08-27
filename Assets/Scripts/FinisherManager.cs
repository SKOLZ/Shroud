using UnityEngine;
using System.Collections;

public class FinisherManager : MonoBehaviour {

	public ClockManager cm;

	void Start () {
	
	}
	
	void OnCollitionEnter2D (Collider2D col) {
		if(cm.getHour() > 8) {
			Application.LoadLevel(3);
		} else {
			//play audio 
		}
	}
}
