using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public GameObject spawn;

	protected GameObject Spawn() {
		return (GameObject)Instantiate(spawn, transform.position, transform.rotation);
	}
}

