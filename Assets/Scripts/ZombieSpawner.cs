using UnityEngine;
using System.Collections;

public class ZombieSpawner : Spawner {	

	public GameObject zombie;

	void Start() {
		InvokeRepeating("ZombieSpawn", 0, spawnRate);
	}

	void ZombieSpawn() {
		int i;
		for (i=0; i<spawns.Count; i++) {
			GameObject zombie2 = Instantiate (zombie, spawns[i].transform.position, spawns[i].transform.rotation) as GameObject;
			zombie2.SetActive(true);
		}
	}
}

