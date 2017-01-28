using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject[] enemies;
	public Vector3 spawnStuff;
	public float spawnWait;
	public int startWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public bool stopSpawning;
	int randomEnemy;

	void Start () {
		StartCoroutine (Spawner());
	
	}

	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	
	}

	IEnumerator Spawner()
	{
		yield return new WaitForSeconds (startWait);
		while (!stopSpawning) 
		{
			randomEnemy = Random.Range (0, 2);

			Vector3 spawnPos = new Vector3(Random.Range(-spawnStuff.x, spawnStuff.x), 1, Random.Range(-spawnStuff.z, spawnStuff.z));

			Instantiate (enemies [randomEnemy], spawnPos + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);

		}
	}
}
