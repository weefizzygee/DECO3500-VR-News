using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	public RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray (transform.position, transform.forward);
		Debug.DrawRay (transform.position, transform.forward * 50);
		if(Physics.Raycast(ray, out hit, 50)) 
		{
			Debug.Log("HIT!");
			if (hit.collider.tag == "box") {
				Debug.Log("It's a box!");
				StartCoroutine(changeColourGreen(hit.collider.gameObject.renderer));
			}
		}
	}

	IEnumerator changeColourGreen (Renderer rend) {
		Color colour = rend.material.color;
		rend.material.color = Color.green;
		Debug.Log("Turned it green!");
		yield return new WaitForSeconds(1);
		rend.material.color = Color.gray;
		Debug.Log("Returned to normal!");
	}
}