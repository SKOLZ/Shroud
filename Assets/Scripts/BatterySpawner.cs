using UnityEngine;
using System.Collections;

public class BatterySpawner : Spawner {	

	public GameObject battery;

	void Start() {
		InvokeRepeating("SpawnBatery", 0, spawnRate);
	}

	protected void SpawnBatery() {
		if(spawnAmount > spawns.Count) {
			spawnAmount = 3;
		}
		for(int i=0 ; i<spawnAmount ; i++ ) {
			int randomNumber = Mathf.FloorToInt(Random.Range(0, spawns.Count));
			GameObject fullBattery = Instantiate(battery, spawns[randomNumber].transform.position, spawns[randomNumber].transform.rotation) as GameObject;
			fullBattery.SetActive(true);
		}
	}
}