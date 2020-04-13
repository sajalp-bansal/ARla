using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableInfoCanvas : MonoBehaviour {

    public GameObject toggle;
    public GameObject canvasInfo;

	public void OnTouch()
    {
        toggle.SetActive(false);
        canvasInfo.SetActive(true);
    }
}
