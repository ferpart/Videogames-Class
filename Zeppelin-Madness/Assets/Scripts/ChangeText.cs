using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    public Text myText;
    public int newFontSize;
    public string newString;
    public Color newColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
        if (Input.GetMouseButtonDown(0))
        {
            myText.text = newString;
            myText.fontSize = newFontSize;

        }
        
        
	}
}
