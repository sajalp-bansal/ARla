using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectToPOI : MonoBehaviour {
    public Button button;
	// Use this for initialization
	public void ButtonClick()
    {
        string map = button.GetComponentInChildren<Text>().text;
        map = "http://maps.google.com/maps?q=" + map;
        Application.OpenURL(map);
    }
}
