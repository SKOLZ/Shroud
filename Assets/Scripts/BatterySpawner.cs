using UnityEngine;
using System.Collections;

public class BatterySpawner : Spawner {	
	
	public float spawnRate = 20.0f;
	
	void Start() {
		InvokeRepeating("Spawn", 0, spawnRate);
	}
}