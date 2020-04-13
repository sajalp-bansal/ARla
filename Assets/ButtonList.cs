using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonList : MonoBehaviour {

    public GameObject buttonPrefab;
    public Transform Panel;
    int [] arr = {1,2,3,4};
	// Use this for initialization
	void Start () {
        for(int i=0;i<arr.Length;i++)
        {
            GameObject button = (GameObject)Instantiate(buttonPrefab);
            button.SetActive(true);
            button.GetComponentInChildren<Text>().text = arr[i].ToString();
            button.transform.parent = Panel;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
