﻿#pragma strict

var news4 : Texture;
var audio4 : AudioClip;

function OnMouseDown () { 
	var otherObject1: GameObject = GameObject.Find("News1");
	var otherObject2: GameObject = GameObject.Find("News2");
	var otherObject3: GameObject = GameObject.Find("News3");
	otherObject1.renderer.material.mainTexture = news4;
	otherObject1.audio.clip = audio4;
	otherObject1.audio.Play();
	otherObject2.audio.Stop();
	otherObject3.audio.Stop();
}