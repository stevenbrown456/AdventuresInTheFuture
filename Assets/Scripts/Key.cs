﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool inventory;  //if true this object can be stored in inventory


	public void DoInteraction()
    {
        gameObject.SetActive(false);
    }

}
