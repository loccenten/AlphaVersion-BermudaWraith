﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes : MonoBehaviour {

    [SerializeField] private string newLevel;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("touch");
        if (other.gameObject.tag == ("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
