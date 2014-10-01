#pragma strict

var SoundSource : GameObject;

function OnMouseDown () { 
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject3: GameObject = GameObject.Find("News3");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject2.audio.Pause();
	otherObject3.audio.Pause();
	otherObject4.audio.Pause();
	SoundSource.audio.Play(); 
}

