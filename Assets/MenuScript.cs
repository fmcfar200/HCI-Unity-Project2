using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour {


	public void GoToMenu()

	{
		Application.LoadLevel("Main Menu");
	}
	public void GoToHelp()
	{
		Application.LoadLevel("Help Menu");
	}

	public void GoToLevel()
	{
		Application.LoadLevel("Game");

	}
	public void GoToEnd()
	{
		Application.LoadLevel("End Scene");

	}
	public void GoToWebsite()
	{
		//takes user to website
		Application.OpenURL("http://www.gov.scot/Topics/Environment/waste-and-pollution/Waste-1");
	}
	void Update()
	{
		if (Application.loadedLevelName == "End Scene")
		{
			ScoreScript scoreScriptGameManager;
			ScoreScript scoreScriptScoreObject;
			GameObject gameManager = GameObject.Find("GameManager");
			GameObject scoreObject = GameObject.Find("ScoreObject");
			if (gameManager !=null && scoreObject !=null)
			{
				scoreScriptGameManager = gameManager.GetComponent<ScoreScript>();
				scoreScriptScoreObject = scoreObject.GetComponent<ScoreScript>();

				scoreScriptScoreObject.playerScore = scoreScriptGameManager.playerScore;
			
			}
			else
			{
				Debug.LogError("GAME MANAGER NOT FOUND");
			}
		}
	}



	
}
