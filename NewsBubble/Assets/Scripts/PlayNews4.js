#pragma strict

var SoundSource : GameObject;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject3: GameObject = GameObject.Find("News3");
	otherObject1.audio.Pause();
	otherObject2.audio.Pause();
	otherObject3.audio.Pause();
	SoundSource.audio.Play(); 
}