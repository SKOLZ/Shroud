using UnityEngine;
using System.Collections;

public class ZombieSpawner : Spawner {	

	public GameObject zombieTarget;
	public float spawnRate = 5.0f;

	void Start() {
		InvokeRepeating("ZombieSpawn", 0, spawnRate);
	}

	void ZombieSpawn() {
		GameObject zombie = Spawn ();
		zombie.GetComponent<EnemyMobility> ().player = zombieTarget;
		zombie.GetComponent<ZombieSounds> ().player = zombieTarget;
	}
}

