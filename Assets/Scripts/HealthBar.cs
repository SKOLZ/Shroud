using UnityEngine;
using System.Collections;

public class HealthBar : RandomSounds {
	public float barDisplay = 1.0f;
	public Vector2 pos = new Vector2(550,10);
	public Vector2 size = new Vector2(60,20);
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public GameObject zombie;
	public GameObject gameOverPopup;
	public Vector3 playerPos;
	public float idleTime;
	public float maxIdleTime = 5.0f;
	private Animator animCtrl;
	public GameObject corpse;

	void Start() {
		animCtrl = GetComponent<Animator>();
	}

	void OnGUI() {
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
		GUI.DrawTexture(new Rect(0,0, size.x * barDisplay, size.y), fullTex);
		GUI.EndGroup();
	}

	void FixedUpdate() {
		if(gameObject != null) {    
			if (transform.localPosition.Equals(playerPos)) {
				idleTime += Time.fixedDeltaTime;
				if(idleTime > maxIdleTime)
					barDisplay -= 0.001f;
				if(barDisplay <= 0.0f) {
					Instantiate(corpse, gameObject.transform.position, gameObject.transform.rotation);
					Destroy(gameObject);
					gameOverPopup.SetActive(true);
				}
			} else {
				playerPos = transform.localPosition;
				idleTime = 0.0f;
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name.Contains(zombie.name)) {
			barDisplay -= 0.2f;
			if(barDisplay <= 0.0f) {
				Instantiate(corpse, gameObject.transform.position, gameObject.transform.rotation);
				Destroy(gameObject);
				gameOverPopup.SetActive(true);
			} else  {
				playSound();
			}
		}
	}
}

