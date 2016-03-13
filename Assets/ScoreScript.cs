using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;
	public int playerScore;
	ItemSpawnScript itemSpawnScript;
	GameObject itemSpawn;

	// Use this for initialization
	void Start () 
	{
		itemSpawn = GameObject.Find("FoodSpawn");
		if (Application.loadedLevelName == "Game") {
			playerScore = 0;
			DontDestroyOnLoad(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Application.loadedLevelName == "Game") {
			scoreText.text = playerScore.ToString ();
		}

		if (playerScore == 0) {
			ItemSpawnScript itemSpawn;
			GameObject itemSpawnObj = GameObject.Find("FoodSpawn");
			if (itemSpawnObj != null)
			{
				itemSpawn = itemSpawnObj.GetComponent<ItemSpawnScript>();
				itemSpawn.ResetItemSpeed();
				Debug.Log("items reset");
			}
			else
			{
				Debug.LogError("ITEM SPAWN NOT FOUND");
			}
		}
	}

	public void AddScore()
	{
		playerScore += 10;
		if (itemSpawn != null) {
			itemSpawnScript = itemSpawn.GetComponent<ItemSpawnScript> ();
			itemSpawnScript.SpeedUpAndLowerDelay (0.05f, 0.05f);
		}
	}
}
