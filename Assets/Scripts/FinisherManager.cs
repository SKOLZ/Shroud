using UnityEngine;
using System.Collections;

public class FinisherManager : MonoBehaviour {

	public ClockManager cm;
	public GameObject player;

	void Start () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.name.Contains (player.name)) { 
			if (cm.getHour () > 8 && cm.getHour () < 17) {
					Application.LoadLevel (2);
			} else {
					//play audio 
			}
		}
	}
}
