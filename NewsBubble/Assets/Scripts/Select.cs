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
			Debug.Log("HIT");
		}
	}
}