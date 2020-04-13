using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLinker : MonoBehaviour {
    Scene currentScene;
    public Button Imagebutton;
    public Button Locationbutton;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "ImageBased")
        {
            Imagebutton.interactable = false;
            Locationbutton.interactable = true;
        }
        else
        {
            Imagebutton.interactable = true;
            Locationbutton.interactable = false;
        }
    }
   

    public void OnTouch()
    {
        Imagebutton.GetComponentInChildren<Button>().onClick.AddListener(() => { SceneManager.LoadScene("ImageBased"); });
        Locationbutton.GetComponentInChildren<Button>().onClick.AddListener(() => { SceneManager.LoadScene("LocationBased"); });

    }
}
