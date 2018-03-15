using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabClick : MonoBehaviour {
public Renderer tab1, tab1top;
public Renderer tab2,tab2top;
public Renderer tab3, tab3top;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown()
	{
		tab2.enabled = true;
		tab1.enabled = false;
		tab3.enabled = false;
		tab2top.enabled = true;
		tab1top.enabled = false;
		tab3top.enabled = false;
	}
}
