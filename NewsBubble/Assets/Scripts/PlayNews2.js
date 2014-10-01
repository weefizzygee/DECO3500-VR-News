#pragma strict

var SoundSource : GameObject;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject3: GameObject = GameObject.Find("News3");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject1.audio.Pause();
	otherObject3.audio.Pause();
	otherObject4.audio.Pause();
	SoundSource.audio.Play(); 
}