﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RefreshScene : MonoBehaviour {

	public void onClick()
    {
        SceneManager.LoadScene("LocationBased");
    }
}
