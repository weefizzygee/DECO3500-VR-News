using UnityEngine;
using System.Collections;

public class escapeApplication : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Application.loadedLevelName.Equals("ArticleView")){
				Application.Quit();
			} else {
				Application.LoadLevel("ArticleView");
			}
		} else {
		}
	}
}
