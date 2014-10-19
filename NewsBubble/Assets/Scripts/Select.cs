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
	public Image ToWorldViewButton;
	public Image ToDashBoardButton;
	public Image ToTopStoriesButton;
	public Image ToMoreStoriesButton;
	public Image ToSingleArticle;
	public Image ToSingleNews;
	
	// Update is called once per frame
	void Update () {
		// When camera hovers over an interactable object, something happens
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;
		Color blueButton = new Color(75, 113, 216, 150);
		if (Application.loadedLevelName.Equals("WorldViewScene")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "America") {
					Color color = AmericaBorder.color;
					color = Color.cyan;
					color.a = 170f;
					AmericaBorder.color = color;
				} else if (hitObject.tag == "S.America") {
					Color color = SAmericaBorder.color;
					color = Color.cyan;
					color.a = 170f;
					SAmericaBorder.color = color;
				} else if (hitObject.tag == "Europe") {
					Color color = EuropeBorder.color;
					color = Color.cyan;
					color.a = 170f;
					EuropeBorder.color = color;
				} else if (hitObject.tag == "Africa") {
					Color color = AfricaBorder.color;
					color = Color.cyan;
					color.a = 170f;
					AfricaBorder.color = color;
				} else if (hitObject.tag == "Asia") {
					Color color = AsiaBorder.color;
					color = Color.cyan;
					color.a = 170f;
					AsiaBorder.color = color;
				} else if (hitObject.tag == "Australia") {
					Color color = AustraliaBorder.color;
					color = Color.cyan;
					color.a = 170f;
					AustraliaBorder.color = color;
				}
			} else {
				Color color = AmericaBorder.color;
				color.a = 0f;
				AmericaBorder.color = color;
				SAmericaBorder.color = color;
				EuropeBorder.color = color;
				AfricaBorder.color = color;
				AsiaBorder.color = color;
				AustraliaBorder.color = color;
			}
		} else if (Application.loadedLevelName.Equals ("Dashboard")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "ToWorldMap") {
					Color color = Color.cyan;
					color.a = 255f;
					ToWorldViewButton.color = color;
				} else if (hitObject.tag == "ToTopStories") {
					Color color = Color.cyan;
					color.a = 255f;
					ToTopStoriesButton.color = color;
				} else {
					ToWorldViewButton.color = Color.white;
					ToTopStoriesButton.color = Color.white;
				}
			} else {
				ToWorldViewButton.color = Color.white;
				ToTopStoriesButton.color = Color.white;
			}

		} else if (Application.loadedLevelName.Equals ("Top_Stories")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "ToWorldMap") {
					Color color = Color.cyan;
					color.a = 255f;
					ToWorldViewButton.color = color;
				} else if (hitObject.tag == "ToDashBoard") {
					Color color = Color.cyan;
					color.a = 255f;
					ToDashBoardButton.color = color;
				} else if (hitObject.tag == "ToMoreStories") {
					Color color = Color.cyan;
					color.a = 255f;
					ToMoreStoriesButton.color = color;
				} else {
					ToWorldViewButton.color = blueButton;
					ToMoreStoriesButton.color = blueButton;
					ToDashBoardButton.color = blueButton;
				}
			} else {
				ToWorldViewButton.color = blueButton;
				ToMoreStoriesButton.color = blueButton;
				ToDashBoardButton.color = blueButton;
			}
		} else if (Application.loadedLevelName.Equals ("More_Stories")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "ToWorldMap") {
					Color color = Color.cyan;
					color.a = 255f;
					ToWorldViewButton.color = color;
				} else if (hitObject.tag == "ToTopStories") {
					Color color = Color.cyan;
					color.a = 255f;
					ToTopStoriesButton.color = color;
				} else {
					ToWorldViewButton.color = blueButton;
					ToTopStoriesButton.color = blueButton;
				}
			} else {
				ToWorldViewButton.color = blueButton;
				ToTopStoriesButton.color = blueButton;
			}
		} else if (Application.loadedLevelName.Equals ("Single_Article")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "ToWorldMap") {
					Color color = Color.cyan;
					color.a = 255f;
					ToWorldViewButton.color = color;
				} else if (hitObject.tag == "ToMoreStories") {
					Color color = Color.cyan;
					color.a = 255f;
					ToMoreStoriesButton.color = color;
				} else {
					ToWorldViewButton.color = blueButton;
					ToMoreStoriesButton.color = blueButton;
				}
			} else {
				ToWorldViewButton.color = blueButton;
				ToMoreStoriesButton.color = blueButton;
			}
		} else if (Application.loadedLevelName.Equals ("Single_News")) {
			if (Physics.Raycast (ray, out hit, 5000000)) {
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.tag == "ToWorldMap") {
					Color color = Color.cyan;
					color.a = 255f;
					ToWorldViewButton.color = color;
				} else if (hitObject.tag == "ToMoreStories") {
					Color color = Color.cyan;
					color.a = 255f;
					ToMoreStoriesButton.color = color;
				}  else {
					ToWorldViewButton.color = blueButton;
					ToMoreStoriesButton.color = blueButton;
				}
			}  else {
				ToWorldViewButton.color = blueButton;
				ToMoreStoriesButton.color = blueButton;
			}
		}
		//	if (Physics.Raycast (ray, out hit, 5000000)) {
		//		GameObject hitObject = hit.transform.gameObject;
		
		//	}
	}
}