using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private Rect retry = new Rect(Screen.width/2-50,Screen.height/2,100,40);
	private Rect quit = new Rect(Screen.width/2-50,Screen.height/2 +50,100,40);

	public GUIStyle retryButton;
	public GUIStyle exitButton;

	void OnGUI(){
		if(GUI.Button(retry, "", retryButton)){
			Application.LoadLevel(0);
		}
		if(GUI.Button(quit,"", exitButton)){
			Application.Quit();
		}
	}
}
