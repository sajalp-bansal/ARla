using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour {

    public Image image;
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        //This is a coroutine
         yield return new WaitForSeconds(2);
        image.enabled = false;



    }

   
}
