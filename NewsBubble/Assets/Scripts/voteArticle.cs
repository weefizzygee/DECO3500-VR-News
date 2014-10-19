using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class voteArticle : MonoBehaviour {

	public Text LikeCounter;
	int likes = 0;
	
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("voteArticle") == null){
			
			PlayerPrefs.SetInt("voteArticle", 0);
		}		
		likes = PlayerPrefs.GetInt("voteArticle");
		LikeCounter.text = likes.ToString ();
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		likes++;
		PlayerPrefs.SetInt("voteArticle", likes);
		LikeCounter.text = likes.ToString();
	}
}
