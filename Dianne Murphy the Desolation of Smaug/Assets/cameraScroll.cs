using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float moveSpeed = 100f;
	public Camera cam;
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") > 0f ) // forward
		{
			Debug.Log("up");
			transform.position += Vector3.up * moveSpeed;
		}
		else if (Input.GetAxis("Mouse ScrollWheel") < 0f ) // backwards
		{
			transform.position += -Vector3.up * moveSpeed;
		}
	}
}
