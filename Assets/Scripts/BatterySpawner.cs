using UnityEngine;
using System.Collections;

public class BatterySpawner : Spawner {	

	public GameObject battery;

	void Start() {
		InvokeRepeating("SpawnBatery", 0, spawnRate);
	}

	protected void SpawnBatery() {
		int randomNumber = Mathf.FloorToInt(Random.Range(0, spawns.Count));
		GameObject battery2 = Instantiate(battery, spawns[randomNumber].transform.position, spawns[randomNumber].transform.rotation) as GameObject;
		battery2.SetActive(true);
	}
}