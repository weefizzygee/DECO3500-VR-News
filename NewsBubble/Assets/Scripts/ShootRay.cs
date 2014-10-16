using UnityEngine;
using System.Collections;

public class ShootRay : MonoBehaviour {

	void OnEnable() 
	{
		MagnetSensor.OnCardboardTrigger += ShootSelectRay;
	}

	void OnDisable() 
	{
		MagnetSensor.OnCardboardTrigger -= ShootSelectRay;
	}

	void ShootSelectRay() 
	{
		// Shoot a ray and perform certain actions when hitting certain objects
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
			} else if (hitObject.tag == "ToWorldMap") {
				Application.LoadLevel("WorldViewScene");
			} else if (hitObject.tag == "ToMoreStories") {
				Application.LoadLevel("More_Stories");
			}else if (hitObject.tag == "ToDashBoard") {
				Application.LoadLevel("DashBoard");
			}else if (hitObject.tag == "ToTopStories") {
				Application.LoadLevel("Top_Stories");
			}else if (hitObject.tag == "SingleArticle") {
				Application.LoadLevel("Single_Article");
			}else if (hitObject.tag == "SingleNews") {
				Application.LoadLevel("Single_News");
			}else if (hitObject.tag == "LikeButton") {
				// Do like
			}else if (hitObject.tag == "SaveButton") {
				// Do save
			}
		}
	}
}
