using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public float barDisplay = 1.0f;
	public Vector2 pos = new Vector2(550,10);
	public Vector2 size = new Vector2(60,20);
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public GameObject zombie;
	
	void OnGUI() {
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
		GUI.DrawTexture(new Rect(0,0, size.x * barDisplay, size.y), fullTex);
		GUI.EndGroup();
	}
	
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name.Contains(zombie.name)) {
			barDisplay -= 0.2f;
		}
	}
}

