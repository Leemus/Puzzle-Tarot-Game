using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab1Click : MonoBehaviour {

	public Renderer tab1, tab1top;
	public Renderer tab2,tab2top;
	public Renderer tab3, tab3top;
	public Renderer twitterpage;
	public GameObject inputfield;


	// Use this for initialization
	void Start () {
		tab2.enabled = false;
		tab1.enabled = true;
		tab3.enabled = false;
		tab2top.enabled = false;
		tab1top.enabled = true;
		tab3top.enabled = false;
		twitterpage.enabled = false;
		inputfield.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown()
	{
		tab2.enabled = false;
		tab1.enabled = true;
		tab3.enabled = false;
		tab2top.enabled = false;
		tab1top.enabled = true;
		tab3top.enabled = false;
		twitterpage.enabled = false;
		inputfield.SetActive(false);
	}
}
