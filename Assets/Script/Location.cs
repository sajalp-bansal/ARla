using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
public class Location : MonoBehaviour {
   
    public Text locationName;
    public Image nameBG;
    public GameObject panel;
    string [] LocName = {"MPSTME", "SBMP", "Mithibai", "Cooper Hospital", "Juhu Beach", "Zarina Park" };
    double[] LocLat = { 19.109, 19.107, 19.102, 19.108, 19.097, 19.044 };
    double[] LocLon = { 72.837, 72.837, 72.837, 72.835, 72.826, 72.924 };
    
       

    IEnumerator Start()
    {
        locationName.text = "";
        nameBG.enabled = false;
        panel.SetActive(false);

        yield return new WaitForSeconds(1);

        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
        {
            locationName.text = "GPS OFF";
            yield break;
        }

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            yield break;
        }
        else
        {
            string latitude, longitude;
            latitude = Input.location.lastData.latitude.ToString();//get latitude
            longitude = Input.location.lastData.longitude.ToString();//get longitude
            latitude = latitude.Substring(0, 6);//clipping string
            longitude = longitude.Substring(0, 6);//clipping string
            double lat = Convert.ToDouble(latitude);//convert to double to allow checking for nearby values
            double lon = Convert.ToDouble(longitude);

            lat = double.Parse(latitude);
            lon = double.Parse(longitude);

            int length = 0;
            length = LocName.Length;
            double [] dist = new double[length];
            double min = -1;
            int minpos = -1;

            for (int i = 0; i < length; i++)//computing shortest distance
            {
                dist [i] =  Math.Sqrt(Math.Pow((LocLat[i] - lat),2) + Math.Pow((LocLon[i] - lon),2) );//computing distance
                if (i == 0)//finding least value
                { min = dist[0]; minpos = 0;}
                else
                {
                    if(min > dist[i])
                    {
                        min = dist[i];minpos = i;
                    }
                }
            }
            if(min >= 0.001)
            {
                if( (lat < 19.111 && lat >19.102) && (lon > 72.836 && lon < 72.840) )//check if irla......lat = 19.111 lon = 72.837....to lat = 19.102 lon = 72.837  .......cooper lat = 19.107  lon = 72.836.....19.107....72.840   
                {
                    locationName.text = "Irla";
                }
                else
                {
                    locationName.text = "N/A";
                }
            }
            else
            {
                panel.SetActive(true);
                locationName.text = LocName[minpos];
                nameBG.enabled = true;
            }
           
            

            
            
        }

        // Stop service if there is no need to query location updates continuously
        Input.location.Stop();
    }

   
}
