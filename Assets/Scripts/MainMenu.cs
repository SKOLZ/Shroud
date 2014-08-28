using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private Rect play = new Rect(220, 250, 100, 40);
	private Rect about = new Rect(220, 320, 100, 40);
	private Rect instructions = new Rect(220, 390, 150, 40);
	private Rect exit = new Rect(220, 460, 100, 40);

	public GUIStyle playStyle;
	public GUIStyle aboutStyle;
	public GUIStyle exitStyle;
	public GUIStyle instructionsStyle;
	public GUITexture aboutText;
	public GUITexture instructionsText;
	public AudioClip jumpScare;
	private bool jumpPlaying;

	void Start() {
		aboutText.enabled = false;
		instructionsText.enabled = false;
		jumpPlaying = false;
	}

	void OnGUI() {
		if(GUI.Button(play, "", playStyle)) {
			audio.Stop();
			audio.loop = false;
			audio.clip = jumpScare;
			audio.Play();
			jumpPlaying = true;
		} 
		if(GUI.Button(about, "", aboutStyle)) {
			aboutText.enabled = !aboutText.enabled;
			instructionsText.enabled = false;
		}
		if(GUI.Button(instructions, "", instructionsStyle)) {
			instructionsText.enabled = !instructionsText.enabled;
			aboutText.enabled = false;
		} 
		if(GUI.Button(exit, "", exitStyle)) {
			Application.Quit();
		}
	}

	void Update() {
		Debug.Log(audio.isPlaying);
		if(jumpPlaying && !audio.isPlaying){
			Application.LoadLevel(1);
		}
	}
}
