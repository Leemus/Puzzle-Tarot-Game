using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab3Click : MonoBehaviour {

	public Renderer tab1, tab1top;
	public Renderer tab2,tab2top;
	public Renderer tab3, tab3top;

		// Use this for initialization
	void Start () {
;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown()
	{
		tab2.enabled = false;
		tab1.enabled = false;
		tab3.enabled = true;
		tab2top.enabled = false;
		tab1top.enabled = false;
		tab3top.enabled = true;
	}
}
