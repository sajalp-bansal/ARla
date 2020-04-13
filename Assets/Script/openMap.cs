using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class openMap : MonoBehaviour {

    public GameObject buttonPrefab;
    public GameObject Panel;
    public Text CreateListFor;

    //public Button button;
    public Text debug;
    // Use this for initialization

        void Start()
       {
         string LookUp = CreateListFor.text;
        LookUp = LookUp.Trim();
        LookUp = LookUp.Substring(0, 1);
        CreateListFor.text = CreateListFor.text + LookUp;
        string[] POI = { "Priya Fast Food: M", "Naturals: M", "Anand Vada Pav: S", "Juhu Beach: Z", "Alfa Stores: S", "Amar Juice Centre: M", "Cooper Hospital: S", "Kailash Parbat: S" };


        for (int i=0;i<POI.Length; i++)
        {
            string temp = POI[i].Substring(POI[i].IndexOf(':') + 1);
            temp = temp.Trim();
            CreateListFor.text = CreateListFor.text + temp;
            if(temp.Equals(LookUp))
            {
                GameObject button = (GameObject)Instantiate(buttonPrefab);
                button.transform.SetParent(Panel.transform);//Setting button parent
                button.transform.GetChild(0).GetComponent<Text>().text = POI[i].Substring(0,POI[i].IndexOf(':'));//Changing text
                button.GetComponent<openMap>().OnTouch();//Setting what button does when clicked
                                                         //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button

            }
            
        }


        /*
        GameObject button = (GameObject)Instantiate(buttonPrefab);
        button.GetComponentInChildren<Text>().text = ResToStr(resolutions[i]);
        int index = i;
        button.GetComponent<Button>().onClick.AddListener(
            () => SetRes(index));

        button.transform.parent = Panel;*/
    }

	public void OnTouch()
    {

        string map = GetComponentInChildren<Text>().text;

        //button.GetComponent<Text>().text;
        map = "http://maps.google.com/maps?q=" + map;
        Application.OpenURL(map);

    }
}
