using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private Rect play = new Rect(220, 250, 100, 40);
	private Rect about = new Rect(220, 320, 100, 40);
	private Rect instructions = new Rect(220, 390, 100, 40);
	private Rect exit = new Rect(220, 460, 100, 40);

	public GUIStyle playStyle;
	public GUIStyle aboutStyle;
	public GUIStyle exitStyle;
	public GUIStyle instructionsStyle;
	public GUITexture aboutText;
	public GUITexture instructionsText;

	void Start() {
		aboutText.enabled = false;
		instructionsText.enabled = false;
	}

	void OnGUI() {
		if(GUI.Button(play, "", playStyle)) {
			Application.LoadLevel(1);
		} 
		if(GUI.Button(about, "", aboutStyle)) {
			aboutText.enabled = !aboutText.enabled;
		}
		if(GUI.Button(instructions, "", instructionsStyle)) {
			instructionsText.enabled = !instructionsText.enabled;
		} 
		if(GUI.Button(exit, "", exitStyle)) {
			Application.Quit();
		}
	}
}
