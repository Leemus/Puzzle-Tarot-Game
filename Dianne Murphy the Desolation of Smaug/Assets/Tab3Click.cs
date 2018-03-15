using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab3Click : MonoBehaviour {

	public Renderer tab1;
	public Renderer tab2;
	public Renderer tab3;

		// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown()
	{
		tab2.enabled = false;
		tab1.enabled = false;
		tab3.enabled = true;
	}
}
