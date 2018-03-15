using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputWho : MonoBehaviour {
	public Renderer tab1, tab1top;
	public Renderer tab2,tab2top;
	public Renderer tab3, tab3top;
	public Renderer twitterpage;
	public GameObject inputfield;
	// Use this for initialization
	void Start () {
		
	}

	public InputField inn;
	// Update is called once per frame
	void Update ()
	{

		if (inn.text == "WackoDestroyer" && Input.GetKey(KeyCode.Return))
		{
			tab2.enabled = false;
			tab1.enabled = false;
			tab3.enabled = false;
			tab2top.enabled = true;
			tab1top.enabled = false;
			tab3top.enabled = false;
			twitterpage.enabled = true;
			inputfield.SetActive(false);
			
		}
	}
}
