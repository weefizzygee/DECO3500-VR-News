using UnityEngine;
using System.Collections;

public class BubbleMovement : MonoBehaviour {
	public float myRotationSpeed = 100.0F;

	public bool isRotateX = false;
	public bool isRotateY = false;
	public bool isRotateZ = false;

	// Set to rotate in positive direction
	private bool postiveRotation = true;

	private int posOrNeg = 1;

	// Use this for initialization
	void Start () {
		collider.isTrigger = true;
		if (postiveRotation == false) {
			posOrNeg = -1;
		}
	}
	
	// Update is called once per frame
	void Update () {

		// Rotate bubble on X axis
		if (isRotateX) {
			transform.Rotate (myRotationSpeed * Time.deltaTime * posOrNeg, 0, 0);
		}
		// Rotate bubble on Y axis
		if (isRotateY) {
			transform.Rotate (0, myRotationSpeed * Time.deltaTime * posOrNeg, 0);
		}
		// Rotate bubble on Z axis
		if (isRotateZ) {
			transform.Rotate (0, 0, myRotationSpeed * Time.deltaTime * posOrNeg);
		}
	}
	
}
