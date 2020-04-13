using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapStarter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "NMIMSDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=NMIMS");
                }
                else if (hit.transform.name == "SVKMDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=SVKM");
                }
                else if (hit.transform.name == "MPSTMEDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=MPSTME");
                }
                else if (hit.transform.name == "DJDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=DJ+Sanghvi");
                }
                else if (hit.transform.name == "NaturalsDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=Naturals+ice+cream");
                }
                else if (hit.transform.name == "KailashDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=Kailash+Parbat");
                }
                else if (hit.transform.name == "AmarDirection")
                {
                    Application.OpenURL("http://maps.google.com/maps?q=Amar+Juice+Centre");
                }
            }
        }

    }
}
