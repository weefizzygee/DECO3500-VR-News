using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	public RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}

	void OnEnable() {
		MagnetSensor.OnCardboardTrigger += ShootSelectRay;
	}

	void OnDisable() {
		MagnetSensor.OnCardboardTrigger -= ShootSelectRay;
	}

	// Update is called once per frame
	void Update () {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		Debug.DrawRay (transform.position, transform.forward * 50);
		if(Physics.Raycast(ray, out hit, 5000000)) 
		{
			GameObject hitObject = hit.transform.gameObject;
			Debug.Log(hitObject.tag);
		}
	}

	void ShootSelectRay() {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		Debug.DrawRay (transform.position, transform.forward * 50);
		if(Physics.Raycast(ray, out hit, 5000000)) 
		{
			GameObject hitObject = hit.transform.gameObject;
			if (hitObject.tag == "America" || hitObject.tag == "S.America"
			    || hitObject.tag == "Europe"|| hitObject.tag == "Africa"
			    || hitObject.tag == "Asia"|| hitObject.tag == "Australia") {
				Application.LoadLevel("Top_Stories");
			}
		}
	}
}