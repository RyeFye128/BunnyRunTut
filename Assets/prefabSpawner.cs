using UnityEngine;
using System.Collections;

public class prefabSpawner : MonoBehaviour {

	private float nextSpawn = 0.0f;
	public Transform prefabToSpawn; //prefab to spawn from.
	public float spawnRate = -1f;
	public float randomDelay = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time > nextSpawn) 
		{
			Instantiate (prefabToSpawn, transform.position, Quaternion.identity);
			nextSpawn = Time.time + spawnRate + Random.Range (0, randomDelay);
		}
	}
}
