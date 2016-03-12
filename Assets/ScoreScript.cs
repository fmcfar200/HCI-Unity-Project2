using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;
	public int playerScore;
	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(this.gameObject);

	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = playerScore.ToString();
		if (playerScore >= 200)
		{
			Application.LoadLevel("End Scene");
		}

	}

	public void AddScore()
	{
		playerScore += 10;

	}
}
