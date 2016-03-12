using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ItemSpawnScript : MonoBehaviour {

	//spawn amount,delay and list
	public int spawnAmount = 10;
	public float spawnDelay = 2.0f;
	public List<GameObject> spawnObjects = new List<GameObject>();

	public float startDelay = 1.5f;	//delay of start
	GameObject gameManager;
	ScoreScript playerScoreScript;
	// Use this for initialization
	void Start () {


		StartCoroutine (SpawnObjects ());
	}

	public void SpeedUpAndLowerDelay(float speedUpAmount, float lowerDelayAmount)
	{
		for (int i = 0; i < spawnObjects.Count;i++)
		{
			spawnObjects[i].GetComponent<ItemScript>().speed += speedUpAmount;
		}
		spawnDelay -= lowerDelayAmount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnObjects()
	{
		//delay before the food begin to spawn
		yield return new WaitForSeconds (startDelay);
		//while the spawn amount is greater than zero
		while (spawnAmount > 0) 
		{
			//finds a random prefab index
			int randomPrefabIndex = Random.Range(0,spawnObjects.Count);
			//spawns the random prefab using the prefab index and the prefab list and waits for the spawn delay
			Instantiate(spawnObjects[randomPrefabIndex] ,this.transform.position,Quaternion.identity);
			yield return new WaitForSeconds(spawnDelay);
			spawnAmount--;   //lowers the spawn amount 


		}
	}


}
