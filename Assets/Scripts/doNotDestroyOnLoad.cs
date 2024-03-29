﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class doNotDestroyOnLoad : MonoBehaviour
{
    public AudioSource audioSource;
        void Awake()
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

            if (objs.Length > 1)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(this.gameObject);
        }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        audioSource.volume = 1;
        if (SceneManager.GetActiveScene().name == "endScene")
        {
            audioSource.volume = 0;
        }
    }
}
