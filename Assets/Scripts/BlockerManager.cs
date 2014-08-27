using UnityEngine;
using System.Collections;

public class BlockerManager : MonoBehaviour {

	public ClockManager cm;
	public GameObject player;
	public AudioClip shouldNotLeaveAudio;

	void update() {
		if (cm.getHour () > 8) {
			this.gameObject.SetActive (false);
		} 
	}
	void OnCollitionEnter2D(Collision2D col) {
		if (col.gameObject.name.Contains (player.name) && this.gameObject.activeSelf) {	
			audio.clip = shouldNotLeaveAudio;
			audio.Play ();
		}
	}
}
