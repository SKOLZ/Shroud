using UnityEngine;
using System.Collections;

public class RandomSounds : MonoBehaviour {

	public AudioClip[] sounds;

	protected void playSound() {
		if (audio.isPlaying) return; // don't play a new sound while the last hasn't finished
		audio.clip = sounds[Random.Range(0,sounds.Length)];
		audio.Play();
	}
}
