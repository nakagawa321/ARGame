﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // android版
    public void onClick()
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            SceneManager.LoadScene("GameMain");
        }

    }
}
