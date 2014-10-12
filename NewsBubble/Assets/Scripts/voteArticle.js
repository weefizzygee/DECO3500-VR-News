#pragma strict
var likeArticle : int;

function Start () {
	if(PlayerPrefs.GetInt("voteArticle") == null){
			
			PlayerPrefs.SetInt("voteArticle", 0);
	}		
	likeArticle = PlayerPrefs.GetInt("voteArticle");
}

function OnMouseDown () {
	likeArticle++;
	PlayerPrefs.SetInt("voteArticle", likeArticle);
}

function OnGUI () {
	GUI.Label(Rect(430,440,160,40), "Like: " + PlayerPrefs.GetInt("voteArticle"));
	GUI.Label(Rect(1070,440,160,40), "Like: " + PlayerPrefs.GetInt("voteArticle"));
}