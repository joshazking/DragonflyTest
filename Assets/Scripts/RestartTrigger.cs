﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death")
        {
            SceneManager.LoadScene(scene.name);
        }

        else
        {

        }
    }
}
