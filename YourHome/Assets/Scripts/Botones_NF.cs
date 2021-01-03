﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones_NF : MonoBehaviour
{
    public List<KeyCode> keys = new List<KeyCode>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keys[0]))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(keys[1]))
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetKeyDown(keys[1]))
        {
            Application.Quit();
        }
    }
}
