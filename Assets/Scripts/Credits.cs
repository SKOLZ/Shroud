using UnityEngine;
using System.Collections;

using UnityEngine;

public class Credits : MonoBehaviour
{
	private float offset;
	private float speed = 15.0f;
	public GUIStyle style;
	private Rect viewArea;
	
	private void Start()
	{
		viewArea = new Rect(0, 0, Screen.width, Screen.height);
		this.offset = Screen.height;
	}
	
	private void Update()
	{
		this.offset -= Time.deltaTime * this.speed;
		if(this.offset <= -720) {
			Application.LoadLevel(0);
		}
	}
	
	private void OnGUI()
	{
		GUI.BeginGroup(this.viewArea);
		
		var position = new Rect(0, this.offset, this.viewArea.width, this.viewArea.height);
		var text = @"You Survived.

GAME DESIGNERS
Iñaki Lanusse
Gabriel Zanzotti

GAME ARTISTS
Iñaki Lanusse
Gabriel Zanzotti

VOICE ACTORS
Iñaki Lanusse
Gabriel Zanzotti

PROGRAMMERS
Iñaki Lanusse
Gabriel Zanzotti

STORY WRITTERS
Iñaki Lanusse
Gabriel Zanzotti

MUSIC BY
Mad World - Gary Jules


In loving memory of Iñaki Lanusse & Gabriel Zanzotti who died to make this real

THANK YOU FOR PLAYING.";
		
		GUI.Label(position, text, this.style);
		
		GUI.EndGroup();
	}
}
