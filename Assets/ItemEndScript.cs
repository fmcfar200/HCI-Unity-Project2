using UnityEngine;
using System.Collections;

public class ItemEndScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Item") {
			Application.LoadLevel("End Scene");
		}
	}
}
