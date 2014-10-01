#pragma strict

var SoundSource : GameObject;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject1.audio.Pause();
	otherObject2.audio.Pause();
	otherObject4.audio.Pause();
	SoundSource.audio.Play(); 
}