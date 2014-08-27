using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Texture2D cursorImage;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}

	void OnGUI() {
		Vector3 mousePos = Input.mousePosition;
		Rect pos = new Rect(mousePos.x,Screen.height - mousePos.y,cursorImage.width,cursorImage.height);
		GUI.Label(pos,cursorImage);
	}
}
