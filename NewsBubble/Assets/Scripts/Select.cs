using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Select : MonoBehaviour {
	public RaycastHit hit;
	public Image AmericaBorder;
	public Image SAmericaBorder;
	public Image EuropeBorder;
	public Image AfricaBorder;
	public Image AsiaBorder;
	public Image AustraliaBorder;
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
		// When camera hovers over an interactable object, something happens
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		Debug.DrawRay (transform.position, transform.forward * 50);
		if(Physics.Raycast(ray, out hit, 5000000)) 
		{
			GameObject hitObject = hit.transform.gameObject;
			if (hitObject.tag == "America") {
				Color color = AmericaBorder.color;
				color.a = 255f;
				AmericaBorder.color = color;
			}
			else if (hitObject.tag == "S.America") {
				Color color = SAmericaBorder.color;
				color.a = 255f;
				SAmericaBorder.color = color;
			}
			else if (hitObject.tag == "Europe") {
				Color color = EuropeBorder.color;
				color.a = 255f;
				EuropeBorder.color = color;
			}
			else if (hitObject.tag == "Africa") {
				Color color = AfricaBorder.color;
				color.a = 255f;
				AfricaBorder.color = color;
			}
			else if (hitObject.tag == "Asia") {
				Color color = AsiaBorder.color;
				color.a = 255f;
				AsiaBorder.color = color;;
			}
			else if (hitObject.tag == "Australia") {
				Color color = AustraliaBorder.color;
				color.a = 255f;
				AustraliaBorder.color = color;
			}
			Debug.Log(hitObject.tag);
		} else{
			Color color = AmericaBorder.color;
			color.a = 0f;
			AmericaBorder.color = color;
			SAmericaBorder.color = color;
			EuropeBorder.color = color;
			AfricaBorder.color = color;
			AsiaBorder.color = color;
			AustraliaBorder.color = color;
		}
	}

	void ShootSelectRay() {
		// On magnet click, do stuff
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		Debug.DrawRay (transform.position, transform.forward * 50);
		if(Physics.Raycast(ray, out hit, 5000000)) 
		{
			GameObject hitObject = hit.transform.gameObject;
			if (hitObject.tag == "America" || hitObject.tag == "S.America"
			    || hitObject.tag == "Europe"|| hitObject.tag == "Africa"
			    || hitObject.tag == "Asia"|| hitObject.tag == "Australia") {
				Application.LoadLevel("Dashboard");
			}
		}
	}
}