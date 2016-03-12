using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour {

	public string itemType;
	public float speed = 0.5f;
	private GameObject target;


	Vector3 offset;
	Vector3 screenPoint;

	// Use this for initialization
	void Start () {

		//sets the target object(where the item is traveling to). Logs error if the target is not found.
		target = GameObject.Find("FoodTarget");
		if (target == null) {
			Debug.LogError("MISSING FOOD END TARGET");
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		//moves the object along the screen
		this.transform.position = Vector2.MoveTowards (transform.position, target.transform.position, speed * Time.deltaTime);


	
	}

	void OnMouseDown()
	{
		//sets the offset from the mouse cursor
		offset = transform.position - Camera.main.ScreenToWorldPoint
			(new Vector3 (Input.mousePosition.x, Input.mousePosition.y,Input.mousePosition.z));



	}
	void OnMouseDrag()
	{
		//holds the mouse position
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,Input.mousePosition.z);
		//mouse point on the screen
		Vector3 mouseScreenPoint = Camera.main.ScreenToWorldPoint(mousePosition) + offset;
		//sets the position of the item to the point on the screen relative to the mouse.
		transform.position = mouseScreenPoint;
	}




}
