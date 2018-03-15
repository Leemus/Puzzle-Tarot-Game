using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabClick : MonoBehaviour {
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
		tab2.enabled = true;
		tab1.enabled = false;
		tab3.enabled = false;
	}
}
