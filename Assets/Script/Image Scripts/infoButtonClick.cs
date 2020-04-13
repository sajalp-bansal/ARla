using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoButtonClick : MonoBehaviour {
    	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "NMIMSInfo")
                {
                    Application.OpenURL("https://en.wikipedia.org/wiki/SVKM%27s_NMIMS");
                }
                else if (hit.transform.name == "SVKMInfo")
                {
                    Application.OpenURL("https://en.wikipedia.org/wiki/Shri_Vile_Parle_Kelavani_Mandal");
                }
                else if (hit.transform.name == "MPSTMEInfo")
                {
                    Application.OpenURL("https://engineering.nmims.edu/");
                }
                else if (hit.transform.name == "DJInfo")
                {
                    Application.OpenURL("http://www.djsce.ac.in/");
                }
                else if (hit.transform.name == "NaturalsInfo")
                {
                    Application.OpenURL("https://www.zomato.com/mumbai/restaurants/natural-ice-cream");
                }
                else if (hit.transform.name == "KailashInfo")
                {
                    Application.OpenURL("https://www.zomato.com/mumbai/kailash-parbat-1-vashi-navi-mumbai");
                }
                else if (hit.transform.name == "AmarInfo")
                {
                    Application.OpenURL("https://www.zomato.com/mumbai/amar-juice-centre-vile-parle-west");
                }
            }

        }
       
		
	}
}
