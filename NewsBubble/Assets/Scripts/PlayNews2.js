#pragma strict

var SoundSource : GameObject;
var news2 : Texture;
var audio2 : AudioClip;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject3: GameObject = GameObject.Find("News3");
	var otherObject4: GameObject = GameObject.Find("News4");
	otherObject1.audio.Stop();
	otherObject3.audio.Stop();
	otherObject4.audio.Stop();
	otherObject1.renderer.material.mainTexture = news2;
  	otherObject1.audio.clip = audio2;
	SoundSource.audio.Play();
}
