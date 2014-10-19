using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class voteNews : MonoBehaviour {

	public Text LikeCounter;
	int likes = 0;
	
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("voteNews") == null){
			
			PlayerPrefs.SetInt("voteNews", 0);
		}		
		likes = PlayerPrefs.GetInt("voteNews");
		LikeCounter.text = likes.ToString ();
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		likes++;
		PlayerPrefs.SetInt("voteNews", likes);
		LikeCounter.text = likes.ToString();
	}
}
