﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;
     

    // Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;
		
	}
	
	// Update is called once per frame
	void Update () {
        //if key is pressed sound effect will play
        if (Input.GetKeyDown(KeyCode.Space))
            MusicSource.Play();
		
	}
}
