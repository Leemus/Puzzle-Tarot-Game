using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab1Click : MonoBehaviour {

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
		tab1.enabled = true;
		tab3.enabled = false;
	}
}
