#pragma strict

var news3 : Texture;
var audio3 : AudioClip;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject1.renderer.material.mainTexture = news3;
	otherObject1.audio.clip = audio3;
	otherObject1.audio.Play();
	otherObject2.audio.Stop();
	otherObject4.audio.Stop();
}