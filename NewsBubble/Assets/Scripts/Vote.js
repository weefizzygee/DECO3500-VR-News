#pragma strict
var likes : int;

function Start () {
	if(PlayerPrefs.GetInt("vote") == null){
			
			PlayerPrefs.SetInt("vote", 0);
	}		
	likes = PlayerPrefs.GetInt("vote");
}

function OnMouseDown () {
	likes++;
	PlayerPrefs.SetInt("vote", likes);
}

function OnGUI () {
	GUI.Label(Rect(540,50,160,40), "Like: " + PlayerPrefs.GetInt("vote"));
	GUI.Label(Rect(1180,50,160,40), "Like: " + PlayerPrefs.GetInt("vote"));
}
