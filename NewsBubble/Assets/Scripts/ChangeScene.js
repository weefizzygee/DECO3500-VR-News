#pragma strict

function Start () {
	// Start_Screen showing for 20 seconds before entering map view
	yield WaitForSeconds (10);

	Application.LoadLevel(1);
}

function Update () {

}