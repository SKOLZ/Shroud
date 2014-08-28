using UnityEngine;
using System.Collections;

public class ZombieSpawner : Spawner {	

	public GameObject zombie;

	void Start() {
		InvokeRepeating("ZombieSpawn", 0, spawnRate);
	}

	void ZombieSpawn() {
		if(spawnAmount > spawns.Count) {
			spawnAmount = 4;
		}
		for(int i=0 ; i<spawnAmount ; i++ ) {
			int randomNumber = Mathf.FloorToInt(Random.Range(0, spawns.Count));
			GameObject babyZombie = Instantiate (zombie, spawns[i].transform.position, spawns[i].transform.rotation) as GameObject;
			babyZombie.SetActive(true);
		}
	}
}

