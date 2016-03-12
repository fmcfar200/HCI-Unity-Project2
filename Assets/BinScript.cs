using UnityEngine;
using System.Collections;

public class BinScript : MonoBehaviour {

	GameObject gameManager;
	ScoreScript playerScoreScript;
	ItemSpawnScript itemSpawnScript;

	void Start()
	{
		gameManager = GameObject.Find("GameManager");
		if (gameManager == null)
		{
			Debug.LogError("GAME MANAGER NOT FOUND!!");
		}
		else
		{
			Debug.Log("Game manager found");
			playerScoreScript = gameManager.GetComponent<ScoreScript>();

		}
	}
	//when collider stays in the bin trigger
	void OnTriggerStay2D(Collider2D coll)
	{
		//if the collider gameobject name is item
		if (coll.gameObject.tag == "Item") 
		{
			//finds the items type and checks if it is in the correct bin
			string thisItemType = coll.gameObject.GetComponent<ItemScript>().itemType;
			if (thisItemType == "Glass" || thisItemType == "Plastic" || thisItemType == "Paper") 
			{
				if (this.gameObject.name == "Blue")
				{
					//destroys the object and adds score
					Destroy(coll.gameObject);
					//add score
					playerScoreScript.AddScore();
				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}
			else if (thisItemType == "Food" )
			{
				if(this.gameObject.name == "Green")
				{
					Destroy(coll.gameObject);
					//add score
					playerScoreScript.AddScore();

				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}
			else if (thisItemType == "Misc" )
			{
				if(this.gameObject.name == "Trash")
				{
					Destroy(coll.gameObject);
					//add score
					playerScoreScript.AddScore();

				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}
		}
		if (playerScoreScript.playerScore == 40)
		{
			GameObject itemSpawn = GameObject.Find("FoodSpawn");
			if (itemSpawn != null)
			{
				itemSpawnScript = itemSpawn.GetComponent<ItemSpawnScript>();
				itemSpawnScript.SpeedUpAndLowerDelay(0.1f,0.05f);
			}
		}
		if (playerScoreScript.playerScore == 80)
		{
			GameObject itemSpawn = GameObject.Find("FoodSpawn");
			if (itemSpawn != null)
			{
				itemSpawnScript = itemSpawn.GetComponent<ItemSpawnScript>();
				itemSpawnScript.SpeedUpAndLowerDelay(0.1f,0.1f);
			}
		}
		if (playerScoreScript.playerScore == 120)
		{
			GameObject itemSpawn = GameObject.Find("FoodSpawn");
			if (itemSpawn != null)
			{
				itemSpawnScript = itemSpawn.GetComponent<ItemSpawnScript>();
				itemSpawnScript.SpeedUpAndLowerDelay(0.2f,0.1f);
			}
		}
		if (playerScoreScript.playerScore == 160)
		{
			GameObject itemSpawn = GameObject.Find("FoodSpawn");
			if (itemSpawn != null)
			{
				itemSpawnScript = itemSpawn.GetComponent<ItemSpawnScript>();
				itemSpawnScript.SpeedUpAndLowerDelay(0.1f,0.1f);
			}
		}
	}
}
