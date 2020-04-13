using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour {

    public GameObject locationScene;
    public GameObject infoScreen;
public void OnClick()
    {
        infoScreen.SetActive(false);
        locationScene.SetActive(true);
    }
}
