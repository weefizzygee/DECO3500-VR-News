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
				color = Color.cyan;
				color.a = 170f;
				AmericaBorder.color = color;
			}
			else if (hitObject.tag == "S.America") {
				Color color = SAmericaBorder.color;
				color = Color.cyan;
				color.a = 170f;
				SAmericaBorder.color = color;
			}
			else if (hitObject.tag == "Europe") {
				Color color = EuropeBorder.color;
				color = Color.cyan;
				color.a = 170f;
				EuropeBorder.color = color;
			}
			else if (hitObject.tag == "Africa") {
				Color color = AfricaBorder.color;
				color = Color.cyan;
				color.a = 170f;
				AfricaBorder.color = color;
			}
			else if (hitObject.tag == "Asia") {
				Color color = AsiaBorder.color;
				color = Color.cyan;
				color.a = 170f;
				AsiaBorder.color = color;;
			}
			else if (hitObject.tag == "Australia") {
				Color color = AustraliaBorder.color;
				color = Color.cyan;
				color.a = 170f;
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
}