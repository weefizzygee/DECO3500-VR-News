#pragma strict

var SoundSource : GameObject;

function OnMouseDown () { 
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject3: GameObject = GameObject.Find("News3");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject2.audio.Stop();
	otherObject3.audio.Stop();
	otherObject4.audio.Stop();
	SoundSource.audio.Play(); 
}
